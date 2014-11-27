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
            return List().Where(a => a.ParentMenuID.HasValue == false).OrderBy(a=>a.Order).ToList();
        }
    }
}
