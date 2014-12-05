using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using Entity;

namespace Budget.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password, int role)
        {
            Result result = null;
            SessionLoginUser sessionLoginUser = null;
            switch (role)
            {
                case 1:
                    CompanyAccountModel cam = new CompanyAccountModel();
                    result = cam.Login(username, password);
                    if (result.HasError == false)
                    {
                        sessionLoginUser = new SessionLoginUser();
                        var ca = result.Entity as CompanyAccount;
                        sessionLoginUser.ID = ca.CompanyID;
                        sessionLoginUser.UserID = ca.ID;
                        sessionLoginUser.CompanyName = ca.Company.Name;
                        sessionLoginUser.UserName = ca.Name;
                        sessionLoginUser.AccountType = 1;
                        sessionLoginUser.RoleIDs = ca.RoleAccounts.Select(a => a.RoleID).ToList();
                        Session["SessionLoginUser"] = sessionLoginUser;
                    }
                    break;
                case 2:
                    GroupAccountModel gam = new GroupAccountModel();
                    result = gam.Login(username, password);
                    if (result.HasError == false)
                    {
                        sessionLoginUser = new SessionLoginUser();
                        var ga = result.Entity as GroupAccount;
                        sessionLoginUser.ID = ga.GroupID;
                        sessionLoginUser.CompanyName = ga.Group.Name;
                        sessionLoginUser.UserName = ga.Name;
                        sessionLoginUser.UserID = ga.ID;
                        sessionLoginUser.AccountType = 0;
                        sessionLoginUser.RoleIDs = ga.RoleAccounts.Select(a => a.RoleID).ToList();
                        Session["SessionLoginUser"] = sessionLoginUser;
                    }
                    break;
            }
            if (result.HasError)
            {
                var data = new { hasError = true, error = result.Error };
                return Json(data);
            }
            else
            {
                var data = new { hasError = false };
                return Json(data);
            }
        }
    }
}
