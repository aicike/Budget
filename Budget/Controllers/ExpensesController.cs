using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;

namespace Budget.Controllers
{
    //费用预算
    public class ExpensesController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        //费用预算表
        public ActionResult Detail(int YearID)
        {
            ViewBag.YearID = YearID;
            Expenses_DetailModel edModel = new Expenses_DetailModel();
            var list = edModel.GetDetailed_ByCompanyID(LoginAccount.ID, YearID);
            ViewBag.List = list;
            //上报后不可编辑
            ProfitLoss_MainModel PMainModel = new ProfitLoss_MainModel();
            var main = PMainModel.GetMainInfo_ByCid_YID(LoginAccount.ID, YearID);
            ParticularYearModel PyearModel = new ParticularYearModel();
            var pyear = PyearModel.Get(YearID);
            ViewBag.YearValue = pyear.Year;
            ViewBag.Year = pyear.Year;
            ViewBag.IsReport = 0; //未上报
            if (main != null)
            {
                if (main.IsReport)
                {
                    ViewBag.IsReport = 1; //已上报
                }
            }
            return View();
        }
    }
}
