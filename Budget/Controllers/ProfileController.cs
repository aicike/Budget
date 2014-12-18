using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using Entity;

namespace Budget.Controllers
{
    public class ProfileController : BaseController
    {
        //
        // GET: /Profile/

        /// <summary>
        /// 公司个人信息修改
        /// </summary>
        /// <param name="imgIsOk">1 修改头像成功,2移除成功</param>
        /// <returns></returns>
        public ActionResult CompanyProFile(int ? imgIsOk)
        {
            CompanyAccountModel CAModel = new CompanyAccountModel();
            var item  = CAModel.Get(LoginAccount.UserID);
            ViewBag.imgIsOk = 0;
            if (imgIsOk.HasValue)
            {
                ViewBag.imgIsOk = imgIsOk;
            }
            return View(item);
        }
        /// <summary>
        /// 修改个人信息(公司)
        /// </summary>
        /// <returns></returns>
        public ActionResult Company_UPProFile(CompanyAccount companyAccount)
        {
            CompanyAccountModel CAModel = new CompanyAccountModel();
            var result = CAModel.Edit(companyAccount);
            if (result.HasError)
            {
                return JavaScript("JMessage('保存失败，稍后再试！',true)");
            }
            else
            {
                return JavaScript("JMessage('保存成功！',false)");
            }
            
        }
        /// <summary>
        /// 修改个人信息(公司)
        /// </summary>
        /// <returns></returns>
        public ActionResult Company_UPPwd(string LsPWD, string newPwd)
        {
            CompanyAccountModel CAModel = new CompanyAccountModel();
            var istrue = CAModel.GetPwdIsRight(LoginAccount.ID, DESEncrypt.Encrypt(LsPWD));
            if (!istrue)
            {
                return JavaScript("JMessage('原始密码错误！',true)");
            }
            var result = CAModel.Up_Pwd(LoginAccount.ID, DESEncrypt.Encrypt(newPwd));
            if (result.HasError)
            {
                return JavaScript("JMessage('密码修改失败，稍后再试！',true)");
            }
            else
            {
                return JavaScript("JMessage('密码修改成功！',false)");
            }
            
        }

        /// <summary>
        /// 修改头像
        /// </summary>
        /// <param name="ImageURL">头像地址</param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="tw"></param>
        /// <param name="th"></param>
        /// <returns></returns>
        public ActionResult Company_UpImage(string ImgPath, int w, int h, int x1, int y1, int tw, int th)
        {
            CompanyAccountModel CAModel = new CompanyAccountModel();
            var result = CAModel.Up_Image(Server.MapPath(ImgPath), LoginAccount.UserID, w, h, x1, y1, tw, th);
            if (result.HasError)
            {
                return JavaScript("JMessage('上传失败,请重试！',true)");
            }
            return JavaScript("window.location.href='" + Url.Action("CompanyProFile", "Profile", new { imgIsOk = 1 }) + "'");
        }

        public ActionResult Company_DelImage()
        {
            CompanyAccountModel CAModel = new CompanyAccountModel();
            var result = CAModel.Del_Image(LoginAccount.UserID);
            if (result.HasError)
            {
                return JavaScript("JMessage('上传失败,请重试！',true)");
            }
            return JavaScript("window.location.href='" + Url.Action("CompanyProFile", "Profile", new { imgIsOk = 2 }) + "'");
        }


        /// <summary>
        /// 集团个人信息修改
        /// </summary>
        /// <returns></returns>
        public ActionResult GroupProFile()
        {
            return View();
        }

    }
}
