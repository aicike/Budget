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
    /// 公司控制器
    /// </summary>
    public class CompanyController : BaseController
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


        /// <summary>
        /// 添加页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {

            return View();
        }
        /// <summary>
        /// 添加公司
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Add(Company company)
        {
            CompanyModel cModel = new CompanyModel();
            company.GroupID = 1;
            cModel.Add(company);
            return JavaScript("window.location.href='" + Url.Action("Index", "Company") + "'");
        }

        /// <summary>
        /// 修改公司页面
        /// </summary>
        /// <param name="CID"></param>
        /// <returns></returns>
        public ActionResult Edit(int CID)
        {
            CompanyModel cModel = new CompanyModel();
            var item = cModel.Get(CID);
            return View(item);
        }
        /// <summary>
        /// 修改公司
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(Company company)
        {
            CompanyModel cModel = new CompanyModel();
            cModel.Edit(company);
            return JavaScript("window.location.href='" + Url.Action("Index", "Company") + "'");
        }
    }
}
