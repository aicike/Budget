using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    /// <summary>
    /// 损益预算真实数据
    /// </summary>
    public class ProfitLossReality_Main : BaseEntity
    {
        /// <summary>
        /// 损益预算 子表ID
        /// </summary>
        [Display(Name = "损益预算 子表ID")]
        public int ID { get; set; }
        public virtual ProfitLoss_Detailed ProfitLoss_Detailed { get; set; }

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
        /// 月份
        /// </summary>
        [Display(Name = "月份")]
        public int Month { get; set; }

        /// <summary>
        /// 是否上报
        /// </summary>
        [Display(Name = "是否上报")]
        public bool IsReport { get; set; }


        /// <summary>
        /// 损益预算真实数据（周）
        /// </summary>
        public virtual ICollection<ProfitLossReality_Detail> ProfitLossReality_Details { get; set; }
    }
}
