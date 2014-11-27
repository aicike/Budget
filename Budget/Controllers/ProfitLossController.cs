using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Budget.Controllers
{
    /// <summary>
    /// 损益预算 控制器
    /// </summary>
    public class ProfitLossController : BaseController
    {
        //损益预算首页
        public ActionResult Index()
        {

            return View();
        }

        //预算表
        public ActionResult Detail()
        {
            return View();
        }
    }
}
