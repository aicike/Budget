using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    /// <summary>
    /// 损益预算 明细表
    /// </summary>
    public class ProfitLoss_Detailed : BaseEntity
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 损益预算 主表ID
        /// </summary>
        [Display(Name = "损益预算 主表ID")]
        public int ProfitLoss_MainID { get; set; }
        public virtual ProfitLoss_Main ProfitLoss_Main { get; set; }

        /// <summary>
        /// 月份
        /// </summary>
        [Display(Name = "月份")]
        public int Month { get; set; }

        /// <summary>
        /// 销售数量
        /// </summary>
        [Display(Name = "销售数量")]
        [Required(ErrorMessage = "请输入销售数量")]
        public decimal XiaoShouShuLiang { get; set; }

        /// <summary>
        /// 新车销售数量
        /// </summary>
        [Display(Name = "新车销售数量")]
        [Required(ErrorMessage = "请输入新车销售数量")]
        public decimal XinCheXiaoShouShuLiang { get; set; }

        /// <summary>
        /// 维修进场台次
        /// </summary>
        [Display(Name = "维修进场台次")]
        [Required(ErrorMessage = "请输入维修进场台次")]
        public decimal WeiXiuJinChangTaiCi { get; set; }

        /// <summary>
        /// 分期数量
        /// </summary>
        [Display(Name = "分期数量")]
        [Required(ErrorMessage = "请输入分期数量")]
        public decimal FenQiShuLiang { get; set; }


        /// <summary>
        /// 新保数量
        /// </summary>
        [Display(Name = "新保数量")]
        [Required(ErrorMessage = "请输入新保数量")]
        public decimal XinBaoShuLiang { get; set; }

        /// <summary>
        /// 续保数量
        /// </summary>
        [Display(Name = "续保数量")]
        [Required(ErrorMessage = "请输入续保数量")]
        public decimal XuBaoShuLiang { get; set; }

        /// <summary>
        /// 延保数量
        /// </summary>
        [Display(Name = "延保数量")]
        public decimal? YanBaoShuLiang { get; set; }


        /// <summary>
        /// 挂牌数量
        /// </summary>
        [Display(Name = "挂牌数量")]
        [Required(ErrorMessage = "请输入挂牌数量")]
        public decimal GuaPaiShuLiang { get; set; }

        /// <summary>
        /// 二手车销售数量
        /// </summary>
        [Display(Name = "二手车销售数量")]
        [Required(ErrorMessage = "请输入二手车销售数量")]
        public decimal ErShouCheXiaoShouShuLiang { get; set; }

        /// <summary>
        /// 主营业务收入
        /// </summary>
        [Display(Name = "主营业务收入")]
        [Required(ErrorMessage = "请输入主营业务收入")]
        public decimal ZhuYingYeWuShouRu { get; set; }

        /// <summary>
        /// 主营业务收入_整车
        /// </summary>
        [Display(Name = "主营业务收入_整车")]
        [Required(ErrorMessage = "请输入主营业务收入_整车")]
        public decimal ZhuYingShouRu_ZhengChe { get; set; }

        /// <summary>
        /// 主营业务收入_售后维修
        /// </summary>
        [Display(Name = "主营业务收入_售后维修")]
        [Required(ErrorMessage = "请输入主营业务收入_售后维修")]
        public decimal ZhuYingShouRu_ShouHouWeiXiu { get; set; }


        /// <summary>
        /// 主营业务收入_维修配件
        /// </summary>
        [Display(Name = "主营业务收入_维修配件")]
        [Required(ErrorMessage = "请输入主营业务收入_维修配件")]
        public decimal ZhuYingShouRu_WeiXiuPeiJian { get; set; }

        /// <summary>
        /// 主营业务收入_工时
        /// </summary>
        [Display(Name = "主营业务收入_工时")]
        [Required(ErrorMessage = "请输入主营业务收入_工时")]
        public decimal ZhuYingShouRu_GongShi { get; set; }


        /// <summary>
        /// 主营业务收入_装饰装潢
        /// </summary>
        [Display(Name = "主营业务收入_装饰装潢")]
        [Required(ErrorMessage = "请输入主营业务收入_装饰装潢")]
        public decimal ZhuYingShouRu_ZhuangShiZhuangHuang { get; set; }

        /// <summary>
        /// 主营业务收入_佣金
        /// </summary>
        [Display(Name = "主营业务收入_佣金")]
        [Required(ErrorMessage = "请输入主营业务收入_佣金")]
        public decimal ZhuYingShouRu_YongJin { get; set; }

        /// <summary>
        /// 主营业务收入_分期
        /// </summary>
        [Display(Name = "主营业务收入_分期")]
        [Required(ErrorMessage = "请输入主营业务收入_分期")]
        public decimal ZhuYingShouRu_FenQi { get; set; }

        /// <summary>
        /// 主营业务收入_保险
        /// </summary>
        [Display(Name = "主营业务收入_保险")]
        [Required(ErrorMessage = "请输入主营业务收入_保险")]
        public decimal ZhuYingShouRu_BaoXian { get; set; }

        /// <summary>
        /// 主营业务收入_新保系数
        /// </summary>
        [Display(Name = "主营业务收入_新保")]
        [Required(ErrorMessage = "请输入主营业务收入_新保")]
        public decimal ZhuYingShouRu_XinBao { get; set; }

        /// <summary>
        /// 主营业务收入_续保
        /// </summary>
        [Display(Name = "主营业务收入_续保")]
        [Required(ErrorMessage = "请输入主营业务收入_续保")]
        public decimal ZhuYingShouRu_XuBao { get; set; }

        /// <summary>
        /// 主营业务收入_延保
        /// </summary>
        [Display(Name = "主营业务收入_延保")]
        public decimal? ZhuYingShouRu_YanBao { get; set; }


        /// <summary>
        /// 主营业务收入_挂牌
        /// </summary>
        [Display(Name = "主营业务收入_挂牌")]
        [Required(ErrorMessage = "请输入主营业务收入_挂牌")]
        public decimal ZhuYingShouRu_GuaPai { get; set; }

        /// <summary>
        /// 主营业务收入_二手车
        /// </summary>
        [Display(Name = "主营业务收入_二手车")]
        [Required(ErrorMessage = "请输入主营业务收入_二手车")]
        public decimal ZhuYingShouRu_ErShouChe { get; set; }

        /// <summary>
        /// 主营业务收入_其他
        /// </summary>
        [Display(Name = "主营业务收入_其他")]
        public decimal? ZhuYingShouRu_QiTa { get; set; }


        /// <summary>
        /// 减：主营业务成本
        /// </summary>
        [Display(Name = "减：主营业务成本")]
        [Required(ErrorMessage = "请输入 减：主营业务成本")]
        public decimal ZhuYingYeWuChengBen { get; set; }

        /// <summary>
        /// 主营业务成本_整车
        /// </summary>
        [Display(Name = "主营业务成本_整车")]
        [Required(ErrorMessage = "请输入主营业务成本_整车")]
        public decimal ZhuYingChengBen_ZhengChe { get; set; }

        /// <summary>
        /// 主营业务成本_售后维修
        /// </summary>
        [Display(Name = "主营业务成本_售后维修")]
        [Required(ErrorMessage = "请输入主营业务成本_售后维修")]
        public decimal ZhuYingChengBen_ShouHouWeiXiu { get; set; }


        /// <summary>
        /// 主营业务成本_维修配件
        /// </summary>
        [Display(Name = "主营业务成本_维修配件")]
        [Required(ErrorMessage = "请输入主营业务成本_维修配件")]
        public decimal ZhuYingChengBen_WeiXiuPeiJian { get; set; }

        /// <summary>
        /// 主营业务成本_工时
        /// </summary>
        [Display(Name = "主营业务成本_工时")]
        public decimal? ZhuYingChengBen_GongShi { get; set; }


        /// <summary>
        /// 主营业务成本_装饰装潢
        /// </summary>
        [Display(Name = "主营业务成本_装饰装潢")]
        [Required(ErrorMessage = "请输入主营业务成本_装饰装潢")]
        public decimal ZhuYingChengBen_ZhuangShiZhuangHuang { get; set; }


        /// <summary>
        /// 主营业务成本_佣金
        /// </summary>
        [Display(Name = "主营业务成本_佣金")]
        public decimal? ZhuYingChengBen_YongJin { get; set; }

        /// <summary>
        /// 主营业务成本_分期
        /// </summary>
        [Display(Name = "主营业务成本_分期")]
        public decimal? ZhuYingChengBen_FenQi { get; set; }

        /// <summary>
        /// 主营业务成本_保险
        /// </summary>
        [Display(Name = "主营业务成本_保险")]
        public decimal? ZhuYingChengBen_BaoXian { get; set; }

        /// <summary>
        /// 主营业务成本_新保
        /// </summary>
        [Display(Name = "主营业务成本_新保")]
        public decimal? ZhuYingChengBen_XinBao { get; set; }

        /// <summary>
        /// 主营业务成本_续保
        /// </summary>
        [Display(Name = "主营业务成本_续保")]
        public decimal? ZhuYingChengBen_XuBao { get; set; }

        /// <summary>
        /// 主营业务成本_延保
        /// </summary>
        [Display(Name = "主营业务成本_延保")]
        public decimal? ZhuYingChengBen_YanBao { get; set; }

        /// <summary>
        /// 主营业务成本_挂牌
        /// </summary>
        [Display(Name = "主营业务成本_挂牌")]
        public decimal? ZhuYingChengBen_GuaPai { get; set; }

        /// <summary>
        /// 主营业务成本_二手车
        /// </summary>
        [Display(Name = "主营业务成本_二手车")]
        public decimal? ZhuYingChengBen_ErShouChe { get; set; }

        /// <summary>
        /// 主营业务成本_其他
        /// </summary>
        [Display(Name = "主营业务成本_其他")]
        public decimal? ZhuYingChengBen_QiTa { get; set; }

    }
}
