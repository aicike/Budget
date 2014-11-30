using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;

namespace Budget.Controllers
{
    /// <summary>
    /// 集团账号控制器
    /// </summary>
    public class GroupAccountController : BaseController
    {
        //
        // GET: /GroupAccount./
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            GroupAccountModel GAModel = new GroupAccountModel();
            var list = GAModel.List().ToList();
            return View(list);
        }

    }
}
