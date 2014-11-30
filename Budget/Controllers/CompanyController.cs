using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;

namespace Budget.Controllers
{
    /// <summary>
    /// 公司控制器
    /// </summary>
    public class CompanyController : Controller
    {
        //
        // GET: /Company/

        /// <summary>
        /// 公司列表
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            CompanyModel Cmodel = new CompanyModel();
            var list = Cmodel.List().ToList();
            return View(list);
        }

    }
}
