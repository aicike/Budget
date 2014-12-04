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

        [HttpPost]
        public ActionResult Add(Role role)
        {
            RoleModel roleModel = new RoleModel();
            var result = roleModel.Add(role);

            if (result.HasError)
            {
                return JavaScript("JMessage('" + result.Error + "',true)");
            }
            return JavaScript("window.location.href='" + Url.Action("Index", "Role") + "'");
        }

        public ActionResult Edit(int id)
        {
            RoleModel roleModel = new RoleModel();
            var role = roleModel.Get(id);
            return View(role);
        }

        [HttpPost]
        public ActionResult Edit(Role role)
        {
            RoleModel roleModel = new RoleModel();
            var result= roleModel.Edit(role);
            if (result.HasError)
            {
                return JavaScript("JMessage('" + result.Error + "',true)");
            }
            return JavaScript("window.location.href='" + Url.Action("Index", "Role") + "'");
        }

        public ActionResult Delete(int id)
        {
            RoleModel roleModel = new RoleModel();
            var result = roleModel.Delete(id);
            if (result.HasError)
            {
                return JavaScript("JMessage('" + result.Error + "',true)");
            }
            return JavaScript("window.location.href='" + Url.Action("Index", "Role") + "'");
        }
    }
}
