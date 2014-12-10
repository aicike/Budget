using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using Entity;

namespace Budget.Controllers
{
    /// <summary>
    /// 系数管理
    /// </summary>
    public class CoefficientController : BaseController
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

        /// <summary>
        /// 损益预算 系数编辑界面
        /// </summary>
        /// <param name="CID"></param>
        /// <returns></returns>
        public ActionResult ProfitLoss_Edit(int CID)
        {
            //获取公司信息
            CompanyModel CModel = new CompanyModel();
            var item = CModel.Get(CID);
            ViewBag.CName = item.Name;
            ViewBag.CID = CID;
            ProfitLoss_CoefficientModel pcModel = new ProfitLoss_CoefficientModel();
            var Citem = pcModel.GetCoefficient_ByCID(CID);
            return View(Citem);
        }

        /// <summary>
        /// 损益预算 系数编辑
        /// </summary>
        /// <param name="CID"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ProfitLoss_Edit(ProfitLoss_Coefficient profitLoss_coefficient)
        {
            ProfitLoss_CoefficientModel pcModel = new ProfitLoss_CoefficientModel();
            var Citem = pcModel.GetIsData_ByCID(profitLoss_coefficient.CompanyID);
            if (Citem)
            {
                pcModel.Edit(profitLoss_coefficient);
            }
            else {
                pcModel.Add(profitLoss_coefficient);
            }
            return JavaScript("window.location.href='" + Url.Action("ProfitLoss_Coefficient", "Coefficient") + "'");
        }
    }
}
