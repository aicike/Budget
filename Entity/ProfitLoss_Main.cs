using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    /// <summary>
    /// 损益预算 主表
    /// </summary>
    public class ProfitLoss_Main : BaseEntity
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        [Display(Name = "公司ID")]
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }

        /// <summary>
        /// 年份ID
        /// </summary>
        [Display(Name = "年份ID")]
        public int ParticularYearID { get; set; }
        public virtual ParticularYear ParticularYear { get; set; }

        /// <summary>
        /// 是否上报
        /// </summary>
        [Display(Name = "是否上报")]
        public bool IsReport { get; set; }

        //----------------------子表------------------------------------------
        /// <summary>
        /// 损益预算 明细表
        /// </summary>
        public virtual ICollection<ProfitLoss_Detailed> ProfitLoss_Detailed { get; set; }

    }
}
