﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 年份表 （数据系统自动生成）
    /// </summary>
    public class ParticularYear : BaseEntity
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 年份
        /// </summary>
        public int Year { get; set; }


        //----------------------子表------------------------------------------
        /// <summary>
        /// 损益预算主表
        /// </summary>
        public virtual ICollection<ProfitLoss_Main> ProfitLoss_Main { get; set; }
    }
}
