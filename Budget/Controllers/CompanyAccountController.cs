using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using Entity;
using Business.Commons;

namespace Budget.Controllers
{
    /// <summary>
    /// 公司账号控制器
    /// </summary>
    public class CompanyAccountController : BaseController
    {
        //
        // GET: /CompanyAccount/

        /// <summary>
        /// 公司账号列表
        /// </summary>
        /// <param name="CID">公司ID 公司链接不填写</param>
        /// <returns></returns>
        public ActionResult Index(int? CID)
        {
            CompanyAccountModel CAModel = new CompanyAccountModel();
            int CompayID = 0;
            //集团链接
            if (CID.HasValue)
            {
                CompayID = CID.Value;
            }
            else //公司链接
            {
                CompayID = LoginAccount.ID; 
            }
            var list = CAModel.GetAccount_BYCID(CompayID);
            //获取公司信息
            CompanyModel CModel = new CompanyModel();
            var item = CModel.Get(CompayID);
            ViewBag.CName = item.Name;
            ViewBag.CID = CompayID;
            return View(list);
        }

        /// <summary>
        /// 添加用户界面 CID:公司ID
        /// </summary>
        /// <returns></returns>
        public ActionResult Add(int CID)
        {
            //获取公司信息
            CompanyModel CModel = new CompanyModel();
            var item = CModel.Get(CID);
            ViewBag.CName = item.Name;
            ViewBag.CID = CID;
            RoleModel rModel = new RoleModel();
            ViewBag.Role = rModel.List().ToList();
            return View();
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="cAccount"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Add(CompanyAccount cAccount, string Roles)
        {
            CompanyAccountModel CAModel = new CompanyAccountModel();
            //校验
            if (CAModel.GetUnameIsOnly(cAccount.AccountNumber))
            {
                return JavaScript("JMessage('登陆账号已存在，请换一个试试！',true)");
            }
            Common Com = new Common();
            var pwd = Com.CreateRandom("",6);
            cAccount.AccountPwd = DESEncrypt.Encrypt(pwd);
            CompanyModel CModel = new CompanyModel();
            var item = CModel.Get(cAccount.CompanyID);
            ViewBag.CName = item.Name;
            //添加
            var result = CAModel.Add(cAccount);
            
            if (result.HasError == false)
            {
                if (Roles != "")
                {
                    //添加角色
                    RoleAccountModel raMoldel = new RoleAccountModel();
                    var strRoles = Roles.TrimEnd(',').Split(',');
                    foreach (string k in strRoles)
                    {
                        RoleAccount roleAccount = new RoleAccount();
                        roleAccount.RoleID = int.Parse(k);
                        roleAccount.CompanyAccountID = cAccount.ID;
                        raMoldel.Add(roleAccount);
                    }
                }
                EmailInfo emailInfo = new EmailInfo();
                emailInfo.To = cAccount.Email;
                emailInfo.Subject = "华夏集团预算系统账号";
                emailInfo.IsHtml = true;
                emailInfo.UseSSL = false;

                var strUrl =  System.Configuration.ConfigurationManager.AppSettings["URl"];
                emailInfo.Body = "您好！<br/><br/>您的华夏集团预算系统账号为："+cAccount.AccountNumber+" <br/><br/>您的密码为：" + pwd + "<br/><br/>请点击<a href='" + strUrl + "'>华夏集团预算系统</a>登陆，尽快更改密码！<br/><br/>----华夏集团预算系统";
                SendEmail.SendMailAsync(emailInfo);
            }
            return JavaScript("window.location.href='" + Url.Action("Index", "CompanyAccount", new { CID=cAccount.CompanyID}) + "'");
        }

        /// <summary>
        /// 修改页面
        /// </summary>
        /// <param name="AccountID"></param>
        /// <returns></returns>
        public ActionResult Edit(int CID,int AccountID)
        {
            //获取公司信息
            CompanyModel CModel = new CompanyModel();
            var item = CModel.Get(CID);
            ViewBag.CName = item.Name;
            ViewBag.CID = CID;
            CompanyAccountModel CAModel = new CompanyAccountModel();
            var Accountitem = CAModel.Get(AccountID);
            RoleModel rModel = new RoleModel();
            ViewBag.Role = rModel.List().ToList();
            //获取角色
            RoleAccountModel raMoldel = new RoleAccountModel();
            ViewBag.RoleS = raMoldel.GetInfo_ByCAID(AccountID).Select(a=>a.RoleID).ToList();
            return View(Accountitem);
        }

        /// <summary>
        /// 修改信息
        /// </summary>
        /// <param name="cAccount"></param>
        /// <param name="Roles"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(CompanyAccount cAccount, string Roles)
        {
            CompanyAccountModel CAModel = new CompanyAccountModel();
            var result = CAModel.Edit(cAccount);
            if (result.HasError == false)
            {
                if (Roles != "")
                {
                    //修改角色
                    RoleAccountModel raMoldel = new RoleAccountModel();
                    raMoldel.Del_ByCAID(cAccount.ID);
                    var strRoles = Roles.TrimEnd(',').Split(',');
                    foreach (string k in strRoles)
                    {
                        RoleAccount roleAccount = new RoleAccount();
                        roleAccount.RoleID = int.Parse(k);
                        roleAccount.CompanyAccountID = cAccount.ID;
                        raMoldel.Add(roleAccount);
                    }
                }
            }
            return JavaScript("window.location.href='" + Url.Action("Index", "CompanyAccount", new { CID = cAccount.CompanyID }) + "'");
        }

        public ActionResult Delete(int CAID,int CID)
        {
            RoleAccountModel raMoldel = new RoleAccountModel();
            raMoldel.Del_ByCAID(CAID);
            CompanyAccountModel CAModel = new CompanyAccountModel();
            CAModel.Delete(CAID);
            return JavaScript("window.location.href='" + Url.Action("Index", "CompanyAccount", new { CID = CID }) + "'");
        }
    }
}
