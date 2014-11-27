using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 预算分类表
    /// </summary>
    public class BudgetClass : BaseEntity
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 预算名称
        /// </summary>
        public string Name { get; set; }

    
    }
}
