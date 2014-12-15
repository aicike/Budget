using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    /// <summary>
    /// 公司主表
    /// </summary>
    public class Company : BaseEntity
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 集团ID
        /// </summary>
        [Display(Name = "集团ID")]
        public int GroupID { get; set; }
        public virtual Group Group { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [Display(Name = "公司名称")]
        [Required(ErrorMessage = "请输入公司名称")]
        [StringLength(100, ErrorMessage = "列名不能超过100字")]
        public string Name { get; set; }


        //----------------------子表------------------------------------------
        /// <summary>
        /// 公司用户表
        /// </summary>
        public virtual ICollection<CompanyAccount> CompanyAccount { get; set; }
        /// <summary>
        /// 公司系数表
        /// </summary>
        public virtual ICollection<ProfitLoss_Coefficient> ProfitLoss_Coefficient { get; set; }

        #region 损益预算
        /// <summary>
        /// 损益预算主表
        /// </summary>
        public virtual ICollection<ProfitLoss_Main> ProfitLoss_Main { get; set; }
        /// <summary>
        /// 损益预算子表
        /// </summary>
        public virtual ICollection<ProfitLoss_Detailed> ProfitLoss_Detailed { get; set; }

        /// <summary>
        /// 损益预算真实数据主表（周）
        /// </summary>
        public virtual ICollection<ProfitLossReality_Main> ProfitLossReality_Mains { get; set; }
        /// <summary>
        /// 损益预算真实数据子表（周）
        /// </summary>
        public virtual ICollection<ProfitLossReality_Detail> ProfitLossReality_Details { get; set; }
        #endregion

        #region 费用预算
        
        public virtual ICollection<Expenses_Main> Expenses_Mains { get; set; }

        public virtual ICollection<Expenses_Detail> Expenses_Details { get; set; }

        #endregion
    }
}
