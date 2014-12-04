using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;
using System.Web.Routing;
using Business;

namespace Budget.Controllers
{
    public class BaseController : Controller
    {
        protected SessionLoginUser LoginAccount
        {
            get
            {
                var account = Session["SessionLoginUser"] as SessionLoginUser;
                return account;
            }
            set { Session["SessionLoginUser"] = value; }
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            var controller = filterContext.RequestContext.RouteData.Values["controller"] as string;
            var action = filterContext.RequestContext.RouteData.Values["action"] as string;
            var area = filterContext.RouteData.DataTokens["area"] as string;

            //上一次请求信息
            string url = "";
            var request = filterContext.RequestContext.HttpContext.Request;
            if (request != null && request.UrlReferrer != null && request.UrlReferrer.AbsolutePath != null)
            {
                url = filterContext.RequestContext.HttpContext.Request.UrlReferrer.AbsoluteUri;
                ViewBag.BackUrl = url;
            }

            if (LoginAccount == null)
            {
                filterContext.Result = new RedirectToRouteResult("Default",
                    new RouteValueDictionary{
                        { "controller", "Login" },
                        { "action", "Index" },
                        { "url",url}
                });
                return;
            }

            //权限
            var menuModel = new MenuModel();
            //menuModel.CheckHasPermissions(LoginAccount.RoleIDs, action, controller, area).NotAuthorizedPage();

            //设置当前Controller和Action，用来判断所在菜单是否高亮显示
            var menu = menuModel.GetMenuByControllerAction(controller, action);
            if (menu != null)
            {
                ViewBag.MenuID = menu.ID;
            }
            else
            {
                ViewBag.MenuID = 0;
            }
            base.OnActionExecuting(filterContext);
        }

    }
}
