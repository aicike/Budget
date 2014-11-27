using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    /// <summary>
    /// 损益预算系数表
    /// </summary>
    public class ProfitLoss_Coefficient : BaseEntity
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
        /// 分期数量系数
        /// </summary>
        [Display(Name = "分期数量系数")]
        [Required(ErrorMessage = "请输入分期数量系数")]
        public double FenQiShuLiang { get; set; }


        /// <summary>
        /// 新保数量系数
        /// </summary>
        [Display(Name = "新保数量系数")]
        [Required(ErrorMessage = "请输入新保数量系数")]
        public double XinBaoShuLiang { get; set; }

        /// <summary>
        /// 续保数量系数
        /// </summary>
        [Display(Name = "续保数量系数")]
        [Required(ErrorMessage = "请输入续保数量系数")]
        public double XuBaoShuLiang { get; set; }

        /// <summary>
        /// 挂牌数量系数
        /// </summary>
        [Display(Name = "挂牌数量系数")]
        [Required(ErrorMessage = "请输入挂牌数量系数")]
        public double GuaPaiShuLiang { get; set; }

        /// <summary>
        /// 二手车销售数量系数
        /// </summary>
        [Display(Name = "二手车销售数量系数")]
        [Required(ErrorMessage = "请输入二手车销售数量系数")]
        public double ErShouCheXiaoShouShuLiang { get; set; }

        /// <summary>
        /// 主营业务收入_整车系数
        /// </summary>
        [Display(Name = "主营业务收入_整车系数")]
        [Required(ErrorMessage = "请输入主营业务收入_整车系数")]
        public double ZhuYingShouRu_ZhengChe { get; set; }

        /// <summary>
        /// 主营业务收入_装饰装潢系数
        /// </summary>
        [Display(Name = "主营业务收入_装饰装潢系数")]
        [Required(ErrorMessage = "请输入主营业务收入_装饰装潢系数")]
        public double ZhuYingShouRu_ZhuangShiZhuangHuang { get; set; }

        /// <summary>
        /// 主营业务收入_分期系数
        /// </summary>
        [Display(Name = "主营业务收入_分期系数")]
        [Required(ErrorMessage = "请输入主营业务收入_分期系数")]
        public double ZhuYingShouRu_FenQi { get; set; }

        /// <summary>
        /// 主营业务收入_新保系数
        /// </summary>
        [Display(Name = "主营业务收入_新保系数")]
        [Required(ErrorMessage = "请输入主营业务收入_新保系数")]
        public double ZhuYingShouRu_XinBao { get; set; }

        /// <summary>
        /// 主营业务收入_续保系数
        /// </summary>
        [Display(Name = "主营业务收入_续保系数")]
        [Required(ErrorMessage = "请输入主营业务收入_续保系数")]
        public double ZhuYingShouRu_XuBao { get; set; }

        /// <summary>
        /// 主营业务收入_挂牌系数
        /// </summary>
        [Display(Name = "主营业务收入_挂牌系数")]
        [Required(ErrorMessage = "请输入主营业务收入_挂牌系数")]
        public double ZhuYingShouRu_GuaPai { get; set; }

        /// <summary>
        /// 主营业务收入_二手车系数
        /// </summary>
        [Display(Name = "主营业务收入_二手车系数")]
        [Required(ErrorMessage = "请输入主营业务收入_二手车系数")]
        public double ZhuYingShouRu_ErShouChe { get; set; }

        /// <summary>
        /// 主营业务成本_整车系数
        /// </summary>
        [Display(Name = "主营业务成本_整车系数")]
        [Required(ErrorMessage = "请输入主营业务成本_整车系数")]
        public double ZhuYingChengBen_ZhengChe { get; set; }

        /// <summary>
        /// 主营业务成本_维修配件系数
        /// </summary>
        [Display(Name = "主营业务成本_维修配件系数")]
        [Required(ErrorMessage = "请输入主营业务成本_维修配件系数")]
        public double ZhuYingChengBen_WeiXiuPeiJian { get; set; }

        /// <summary>
        /// 主营业务成本_装饰装潢系数
        /// </summary>
        [Display(Name = "主营业务成本_装饰装潢系数")]
        [Required(ErrorMessage = "请输入主营业务成本_装饰装潢系数")]
        public double ZhuYingChengBen_ZhuangShiZhuangHuang { get; set; }

    }
}
