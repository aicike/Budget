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
            return View();
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="cAccount"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Add(CompanyAccount cAccount)
        {
            CompanyAccountModel CAModel = new CompanyAccountModel();
            //校验
            if (CAModel.GetUnameIsOnly(cAccount.AccountNumber))
            {
                return JavaScript("Jmessage('登陆账号已存在，请换一个试试！',true)");
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
                EmailInfo emailInfo = new EmailInfo();
                emailInfo.To = cAccount.Email;
                emailInfo.Subject = "华夏集团预算系统账号";
                emailInfo.IsHtml = true;
                emailInfo.UseSSL = false;

                var strUrl =  System.Configuration.ConfigurationManager.AppSettings["URl"];
                emailInfo.Body = "您好！<br/><br/>您的华夏集团预算系统账号为："+cAccount.AccountNumber+"！<br/><br/>您的密码为：" + pwd + "<br/><br/>请点击<a href='" + strUrl + "'>华夏集团预算系统</a>登陆，尽快更改密码！<br/><br/>----华夏集团预算系统";
                SendEmail.SendMailAsync(emailInfo);
            }
            return JavaScript("window.location.href='" + Url.Action("Index", "CompanyAccount", new { CID=cAccount.CompanyID}) + "'");
        }
    }
}
