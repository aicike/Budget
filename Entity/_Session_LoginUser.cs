using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    [Serializable]
    public class SessionLoginUser
    {
        /// <summary>
        /// 0：集团    1：公司
        /// </summary>
        public int AccountType { get; set; }

        /// <summary>
        /// 公司ID或集团ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        public List<int> RoleIDs { get; set; }
    }
}
