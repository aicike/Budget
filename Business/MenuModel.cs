using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Business
{
    public class MenuModel : BaseModel<Menu>
    {
        public List<Menu> GetMenu()
        {
            return List().Where(a => a.ParentMenuID.HasValue == false).OrderBy(a => a.Order).ToList();
        }

        public Menu GetMenuByControllerAction(string controller, string action)
        {
            return List().Where(a => a.Controller.Equals(controller, StringComparison.CurrentCultureIgnoreCase) &&
                a.Action.Equals(action, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
        }

        /// <summary>
        /// 根据角色获取菜单，有层级
        /// </summary>
        /// <param name="systemUserRoleID"></param>
        /// <param name="parentSystemUserMenuID"></param>
        /// <returns></returns>
        public List<Menu> GetMenuByRoleID(List<int> roleIDs, int? parentMenuID = null)
        {
            var list = List().ToList().Where(a => a.RoleMenus.Any(b => roleIDs.Contains(b.RoleID)) && a.ParentMenuID == parentMenuID).OrderBy(a => a.Order).ToList();
            foreach (var item in list)
            {
                item.Menus = item.Menus.Where(a => a.RoleMenus.Any(b => roleIDs.Contains(b.RoleID))).OrderBy(a => a.Order).ToList();
            }
            return list;
        }

        /// <summary>
        /// 检查操作权限
        /// </summary>
        public bool CheckHasPermissions(List<int> roleID, string action, string controller, string area)
        {
            //判断有没有权限操作当前菜单(Contorller)
            RoleMenuModel roleMenuModel = new RoleMenuModel(); ;

            var menu = roleMenuModel.List().Where(a => roleID.Contains(a.RoleID) &&
                                                       ((area != null && a.Menu.Area != null && a.Menu.Area.Equals(area, StringComparison.CurrentCultureIgnoreCase)) || (area == null && a.Menu.Area == null)) &&
                                                       (a.Menu.Controller != null && a.Menu.Controller.Equals(controller, StringComparison.CurrentCultureIgnoreCase))).Select(a => a.Menu).FirstOrDefault();

            if (menu == null) { return false; }

            //判断有没有权限操作当前功能(Action)
            RoleOptionModel roleOptionModel = new RoleOptionModel();
            var result = roleOptionModel.List().Any(a => roleID.Contains(a.RoleID) &&
                                                         a.MenuOption.MenuID == menu.ID &&
                                                         a.MenuOption.Action.Equals(action, StringComparison.CurrentCultureIgnoreCase));
            return result;
        }
    }
}
