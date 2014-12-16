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
        /// 集团系数管理列表页
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
        #region 集团管理
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
            ViewBag.AccountType = LoginAccount.AccountType;
            ProfitLoss_CoefficientModel pcModel = new ProfitLoss_CoefficientModel();
            var Citem = pcModel.GetCoefficient_ByCID(CID);

            if (LoginAccount.AccountType == 1)
            {
                //公司点开预算系数管理时，显示公司菜单
                ViewBag.MenuID = 201;
            }

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
            else
            {
                pcModel.Add(profitLoss_coefficient);
            }
            if (LoginAccount.AccountType == 0)
            {
                return JavaScript("window.location.href='" + Url.Action("ProfitLoss_Coefficient", "Coefficient") + "'");
            }
            else
            {
                return JavaScript("window.location.href='" + Url.Action("CompanyCoefficient", "Coefficient") + "'");
            }
        }
        #endregion

        #region 公司管理

        /// <summary>
        /// 公司系数管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult CompanyCoefficient()
        {
            //获取公司信息
            return RedirectToAction("ProfitLoss_Edit", "Coefficient", new { CID = LoginAccount.ID });
        }


        #endregion

    }
}
