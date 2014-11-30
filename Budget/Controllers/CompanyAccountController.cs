using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;

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
            return View(list);
        }

    }
}
