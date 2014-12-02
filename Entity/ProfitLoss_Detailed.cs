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
        /// 公司ID
        /// </summary>
        [Display(Name = "公司ID")]
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }


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
        public double XiaoShouShuLiang { get; set; }

        /// <summary>
        /// 新车销售数量
        /// </summary>
        [Display(Name = "新车销售数量")]
        [Required(ErrorMessage = "请输入新车销售数量")]
        public double XinCheXiaoShouShuLiang { get; set; }

        /// <summary>
        /// 维修进场台次
        /// </summary>
        [Display(Name = "维修进场台次")]
        [Required(ErrorMessage = "请输入维修进场台次")]
        public double WeiXiuJinChangTaiCi { get; set; }

        /// <summary>
        /// 分期数量
        /// </summary>
        [Display(Name = "分期数量")]
        [Required(ErrorMessage = "请输入分期数量")]
        public double FenQiShuLiang { get; set; }


        /// <summary>
        /// 新保数量
        /// </summary>
        [Display(Name = "新保数量")]
        [Required(ErrorMessage = "请输入新保数量")]
        public double XinBaoShuLiang { get; set; }

        /// <summary>
        /// 续保数量
        /// </summary>
        [Display(Name = "续保数量")]
        [Required(ErrorMessage = "请输入续保数量")]
        public double XuBaoShuLiang { get; set; }

        /// <summary>
        /// 延保数量
        /// </summary>
        [Display(Name = "延保数量")]
        public double? YanBaoShuLiang { get; set; }


        /// <summary>
        /// 挂牌数量
        /// </summary>
        [Display(Name = "挂牌数量")]
        [Required(ErrorMessage = "请输入挂牌数量")]
        public double GuaPaiShuLiang { get; set; }

        /// <summary>
        /// 二手车销售数量
        /// </summary>
        [Display(Name = "二手车销售数量")]
        [Required(ErrorMessage = "请输入二手车销售数量")]
        public double ErShouCheXiaoShouShuLiang { get; set; }

        /// <summary>
        /// 主营业务收入
        /// </summary>
        [Display(Name = "主营业务收入")]
        [Required(ErrorMessage = "请输入主营业务收入")]
        public double ZhuYingYeWuShouRu { get; set; }

        /// <summary>
        /// 主营业务收入_整车
        /// </summary>
        [Display(Name = "主营业务收入_整车")]
        [Required(ErrorMessage = "请输入主营业务收入_整车")]
        public double ZhuYingShouRu_ZhengChe { get; set; }

        /// <summary>
        /// 主营业务收入_售后维修
        /// </summary>
        [Display(Name = "主营业务收入_售后维修")]
        [Required(ErrorMessage = "请输入主营业务收入_售后维修")]
        public double ZhuYingShouRu_ShouHouWeiXiu { get; set; }


        /// <summary>
        /// 主营业务收入_维修配件
        /// </summary>
        [Display(Name = "主营业务收入_维修配件")]
        [Required(ErrorMessage = "请输入主营业务收入_维修配件")]
        public double ZhuYingShouRu_WeiXiuPeiJian { get; set; }

        /// <summary>
        /// 主营业务收入_工时
        /// </summary>
        [Display(Name = "主营业务收入_工时")]
        [Required(ErrorMessage = "请输入主营业务收入_工时")]
        public double ZhuYingShouRu_GongShi { get; set; }


        /// <summary>
        /// 主营业务收入_装饰装潢
        /// </summary>
        [Display(Name = "主营业务收入_装饰装潢")]
        [Required(ErrorMessage = "请输入主营业务收入_装饰装潢")]
        public double ZhuYingShouRu_ZhuangShiZhuangHuang { get; set; }

        /// <summary>
        /// 主营业务收入_佣金
        /// </summary>
        [Display(Name = "主营业务收入_佣金")]
        [Required(ErrorMessage = "请输入主营业务收入_佣金")]
        public double ZhuYingShouRu_YongJin { get; set; }

        /// <summary>
        /// 主营业务收入_分期
        /// </summary>
        [Display(Name = "主营业务收入_分期")]
        [Required(ErrorMessage = "请输入主营业务收入_分期")]
        public double ZhuYingShouRu_FenQi { get; set; }

        /// <summary>
        /// 主营业务收入_保险
        /// </summary>
        [Display(Name = "主营业务收入_保险")]
        [Required(ErrorMessage = "请输入主营业务收入_保险")]
        public double ZhuYingShouRu_BaoXian { get; set; }

        /// <summary>
        /// 主营业务收入_新保系数
        /// </summary>
        [Display(Name = "主营业务收入_新保")]
        [Required(ErrorMessage = "请输入主营业务收入_新保")]
        public double ZhuYingShouRu_XinBao { get; set; }

        /// <summary>
        /// 主营业务收入_续保
        /// </summary>
        [Display(Name = "主营业务收入_续保")]
        [Required(ErrorMessage = "请输入主营业务收入_续保")]
        public double ZhuYingShouRu_XuBao { get; set; }

        /// <summary>
        /// 主营业务收入_延保
        /// </summary>
        [Display(Name = "主营业务收入_延保")]
        public double? ZhuYingShouRu_YanBao { get; set; }


        /// <summary>
        /// 主营业务收入_挂牌
        /// </summary>
        [Display(Name = "主营业务收入_挂牌")]
        [Required(ErrorMessage = "请输入主营业务收入_挂牌")]
        public double ZhuYingShouRu_GuaPai { get; set; }

        /// <summary>
        /// 主营业务收入_二手车
        /// </summary>
        [Display(Name = "主营业务收入_二手车")]
        [Required(ErrorMessage = "请输入主营业务收入_二手车")]
        public double ZhuYingShouRu_ErShouChe { get; set; }

        /// <summary>
        /// 主营业务收入_其他
        /// </summary>
        [Display(Name = "主营业务收入_其他")]
        public double? ZhuYingShouRu_QiTa { get; set; }


        /// <summary>
        /// 减：主营业务成本
        /// </summary>
        [Display(Name = "减：主营业务成本")]
        [Required(ErrorMessage = "请输入 减：主营业务成本")]
        public double ZhuYingYeWuChengBen { get; set; }

        /// <summary>
        /// 主营业务成本_整车
        /// </summary>
        [Display(Name = "主营业务成本_整车")]
        [Required(ErrorMessage = "请输入主营业务成本_整车")]
        public double ZhuYingChengBen_ZhengChe { get; set; }

        /// <summary>
        /// 主营业务成本_售后维修
        /// </summary>
        [Display(Name = "主营业务成本_售后维修")]
        [Required(ErrorMessage = "请输入主营业务成本_售后维修")]
        public double ZhuYingChengBen_ShouHouWeiXiu { get; set; }


        /// <summary>
        /// 主营业务成本_维修配件
        /// </summary>
        [Display(Name = "主营业务成本_维修配件")]
        [Required(ErrorMessage = "请输入主营业务成本_维修配件")]
        public double ZhuYingChengBen_WeiXiuPeiJian { get; set; }

        /// <summary>
        /// 主营业务成本_工时
        /// </summary>
        [Display(Name = "主营业务成本_工时")]
        public double? ZhuYingChengBen_GongShi { get; set; }


        /// <summary>
        /// 主营业务成本_装饰装潢
        /// </summary>
        [Display(Name = "主营业务成本_装饰装潢")]
        [Required(ErrorMessage = "请输入主营业务成本_装饰装潢")]
        public double ZhuYingChengBen_ZhuangShiZhuangHuang { get; set; }


        /// <summary>
        /// 主营业务成本_佣金
        /// </summary>
        [Display(Name = "主营业务成本_佣金")]
        public double? ZhuYingChengBen_YongJin { get; set; }

        /// <summary>
        /// 主营业务成本_分期
        /// </summary>
        [Display(Name = "主营业务成本_分期")]
        public double? ZhuYingChengBen_FenQi { get; set; }

        /// <summary>
        /// 主营业务成本_保险
        /// </summary>
        [Display(Name = "主营业务成本_保险")]
        public double? ZhuYingChengBen_BaoXian { get; set; }

        /// <summary>
        /// 主营业务成本_新保
        /// </summary>
        [Display(Name = "主营业务成本_新保")]
        public double? ZhuYingChengBen_XinBao { get; set; }

        /// <summary>
        /// 主营业务成本_续保
        /// </summary>
        [Display(Name = "主营业务成本_续保")]
        public double? ZhuYingChengBen_XuBao { get; set; }

        /// <summary>
        /// 主营业务成本_延保
        /// </summary>
        [Display(Name = "主营业务成本_延保")]
        public double? ZhuYingChengBen_YanBao { get; set; }

        /// <summary>
        /// 主营业务成本_挂牌
        /// </summary>
        [Display(Name = "主营业务成本_挂牌")]
        public double? ZhuYingChengBen_GuaPai { get; set; }

        /// <summary>
        /// 主营业务成本_二手车
        /// </summary>
        [Display(Name = "主营业务成本_二手车")]
        public double? ZhuYingChengBen_ErShouChe { get; set; }

        /// <summary>
        /// 主营业务成本_其他
        /// </summary>
        [Display(Name = "主营业务成本_其他")]
        public double? ZhuYingChengBen_QiTa { get; set; }


        /// <summary>
        /// 毛利
        /// </summary>
        [Display(Name = "毛利")]
        [Required(ErrorMessage = "请输入毛利")]
        public double MaoLi { get; set; }

        /// <summary>
        /// 毛利_整车
        /// </summary>
        [Display(Name = "毛利_整车")]
        [Required(ErrorMessage = "请输入毛利_整车")]
        public double MaoLi_ZhengChe { get; set; }

        /// <summary>
        /// 毛利_维修
        /// </summary>
        [Display(Name = "毛利_维修")]
        [Required(ErrorMessage = "请输入毛利_维修")]
        public double MaoLi_WeiXiu { get; set; }

        /// <summary>
        /// 毛利_装饰装潢
        /// </summary>
        [Display(Name = "毛利_装饰装潢")]
        [Required(ErrorMessage = "请输入毛利_装饰装潢")]
        public double MaoLi_ZhuangShiZhuangHuang { get; set; }

        /// <summary>
        /// 毛利_佣金
        /// </summary>
        [Display(Name = "毛利_佣金")]
        [Required(ErrorMessage = "请输入毛利_佣金")]
        public double MaoLi_YongJin { get; set; }

        /// <summary>
        /// 主营业务税金及附加
        /// </summary>
        [Display(Name = "主营业务税金及附加")]
        [Required(ErrorMessage = "请输入主营业务税金及附加")]
        public double ZhuYingYeWuShueiJinJiFuJia { get; set; }

        /// <summary>
        /// 主营业务附加税后毛利
        /// </summary>
        [Display(Name = "主营业务附加税后毛利")]
        [Required(ErrorMessage = "请输入主营业务附加税后毛利")]
        public double ZhuYingYeWuFuJiaShuiHouMaoLi { get; set; }

        /// <summary>
        /// 其他业务收入
        /// </summary>
        [Display(Name = "其他业务收入")]
        public double? QiTaYeWuShouRu { get; set; }

        /// <summary>
        /// 其他业务成本
        /// </summary>
        [Display(Name = "其他业务成本")]
        public double? QiTaYeWuChengBen { get; set; }

        /// <summary>
        /// 其他业务税金及附加
        /// </summary>
        [Display(Name = "其他业务税金及附加")]
        public double? QiTaYeWuShuiJinJiFuJia { get; set; }

        /// <summary>
        /// 其他业务利润
        /// </summary>
        [Display(Name = "其他业务利润")]
        public double? QiTaYeWuLiRun { get; set; }

        /// <summary>
        /// 销售及管理费用
        /// </summary>
        [Display(Name = "销售及管理费用")]
        [Required(ErrorMessage = "请输入销售及管理费用")]
        public double XiaoShouJiGuanLiFeiYong { get; set; }

        /// <summary>
        /// 息税前利润
        /// </summary>
        [Display(Name = "息税前利润")]
        [Required(ErrorMessage = "请输入息税前利润")]
        public double XiShueiQianLiRun{ get; set; }

        /// <summary>
        /// 财务费用
        /// </summary>
        [Display(Name = "财务费用")]
        [Required(ErrorMessage = "请输入财务费用")]
        public double CaiWuFeiYong { get; set; }

        /// <summary>
        /// 营业利润
        /// </summary>
        [Display(Name = "营业利润")]
        [Required(ErrorMessage = "请输入营业利润")]
        public double YingYeLiRun { get; set; }

        /// <summary>
        /// 资产减值损失
        /// </summary>
        [Display(Name = "资产减值损失")]
        public double? ZiChanJianZhiSunShi { get; set; }

        /// <summary>
        /// 公允价值变动收益
        /// </summary>
        [Display(Name = "公允价值变动收益")]
        public double? GongYunJiaZhiBianDongShouYi { get; set; }

        /// <summary>
        /// 投资收益
        /// </summary>
        [Display(Name = "投资收益")]
        public double? TouZiShouYi { get; set; }

        /// <summary>
        /// 营业外收支净额
        /// </summary>
        [Display(Name = "营业外收支净额")]
        public double? YingYeWaiShouZhiJingE { get; set; }

        /// <summary>
        /// 利润总额
        /// </summary>
        [Display(Name = "利润总额")]
        [Required(ErrorMessage = "请输入利润总额")]
        public double LiRunZongE { get; set; }

        /// <summary>
        /// 所得税
        /// </summary>
        [Display(Name = "所得税")]
        public double? SuoDeShui { get; set; }

        /// <summary>
        /// 税后利润
        /// </summary>
        [Display(Name = "税后利润")]
        [Required(ErrorMessage = "请输入税后利润")]
        public double ShueiHouLiRun { get; set; }

        /// <summary>
        /// 少数股东损益
        /// </summary>
        [Display(Name = "少数股东损益")]
        public double? ShaoShuGuDongSunYi { get; set; }

        /// <summary>
        /// 净利润
        /// </summary>
        [Display(Name = "净利润")]
        [Required(ErrorMessage = "请输入净利润")]
        public double JingLiRun { get; set; }

        /// <summary>
        /// 损益预算 子表ID
        /// </summary>
        [Display(Name = "损益预算 子表ID")]
        public int? ProfitLossReality_MainID { get; set; }
        public virtual ProfitLossReality_Main ProfitLossReality_Main { get; set; }
    }
}
