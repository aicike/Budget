using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;

namespace Budget.Controllers
{
    /// <summary>
    /// 系数管理
    /// </summary>
    public class CoefficientController : Controller
    {
        //
        // GET: /ProfitLoss_Coefficient/

        /// <summary>
        /// 系数管理列表页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            BudgetClassModel BCModel = new BudgetClassModel();
            var list = BCModel.List().ToList();
            return View(list);
        }

        /// <summary>
        /// 损益预算 系数管理
        /// </summary>
        /// <returns></returns>
        public ActionResult ProfitLoss_Coefficient()
        {
            CompanyModel CModel = new CompanyModel();
            var list = CModel.List().ToList();
            return View(list);
        }

    }
}
