using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;

namespace Budget.Controllers
{
    /// <summary>
    /// 角色管理
    /// </summary>
    public class RoleController : Controller
    {
        public ActionResult Index()
        {
            RoleModel roleModel = new RoleModel();
            var list = roleModel.List().ToList();
            return View(list);
        }

        public ActionResult Add()
        {
            return View();
        }

    }
}
