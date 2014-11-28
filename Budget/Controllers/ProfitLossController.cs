using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using System.Data;

namespace Budget.Controllers
{
    /// <summary>
    /// 损益预算 控制器
    /// </summary>
    public class ProfitLossController : BaseController
    {
        //损益预算首页(公司列表)
        public ActionResult Index()
        {
            ParticularYearModel pyearModel = new ParticularYearModel();
            var list = pyearModel.List().OrderByDescending(a=>a.ID).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Year");
            dt.Columns.Add("YearID");
            dt.Columns.Add("Type"); // 0：已上报 ，1：未上报，2：未填写预算

            foreach (var item in list)
            {
                DataRow row = dt.NewRow();
                row["Year"] = item.Year + "年损益预算";
                row["YearID"] = item.ID;
                if (item.ProfitLoss_Main != null)
                {
                    var profitloss_main = item.ProfitLoss_Main.Where(a=>a.CompanyID == LoginAccount.ID);
                    if (profitloss_main.Count() > 0)
                    {
                        if (profitloss_main.FirstOrDefault().IsReport)
                        {
                            row["Type"] = 0;
                        }
                        else
                        {
                            row["Type"] = 1;
                        }
                    }
                    else
                    {
                        row["Type"] = 2;
                    }
                }
                else
                {
                    row["Type"] = 2;
                }

                dt.Rows.Add(row);
            }
            return View(dt);
        }

        //预算表
        public ActionResult Detail()
        {
            return View();
        }
    }
}
