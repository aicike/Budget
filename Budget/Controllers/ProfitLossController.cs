using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Budget.Controllers
{
    public class ProfitLossController : BaseController
    {
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
