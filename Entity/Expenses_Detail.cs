using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    /// <summary>
    /// 费用预算子表
    /// </summary>
    public class Expenses_Detail : BaseEntity
    {
        public int ID { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        [Display(Name = "公司ID")]
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }


        /// <summary>
        /// 费用预算 主表ID
        /// </summary>
        [Display(Name = "费用预算 主表ID")]
        public int Expenses_MainlID { get; set; }
        public virtual Expenses_Main Expenses_Main { get; set; }

        /// <summary>
        /// 月份
        /// </summary>
        [Display(Name = "月份")]
        public int Month { get; set; }

        #region 职工薪酬

        /// <summary>
        /// 工资
        /// </summary>
        [Display(Name = "工资")]
        [Required(ErrorMessage = "请输入工资")]
        public double GongZi { get; set; }

        /// <summary>
        /// 奖金
        /// </summary>
        [Display(Name = "奖金")]
        [Required(ErrorMessage = "请输入奖金")]
        public double Jiangjin { get; set; }

        /// <summary>
        /// 福利费
        /// </summary>
        [Display(Name = "福利费")]
        [Required(ErrorMessage = "请输入福利费")]
        public double FuLiFei { get; set; }

        /// <summary>
        /// 员工保险
        /// </summary>
        [Display(Name = "员工保险")]
        [Required(ErrorMessage = "请输入员工保险")]
        public double YuanGongBaoXian { get; set; }

        /// <summary>
        /// 职工教育经费
        /// </summary>
        [Display(Name = "职工教育经费")]
        [Required(ErrorMessage = "请输入职工教育经费")]
        public double ZhiGongJiaoYuJingFei { get; set; }

        /// <summary>
        /// 工会经费
        /// </summary>
        [Display(Name = "工会经费")]
        [Required(ErrorMessage = "请输入工会经费")]
        public double GongHuiFeiYong { get; set; }

        /// <summary>
        /// 辞退福利
        /// </summary>
        [Display(Name = "辞退福利")]
        [Required(ErrorMessage = "请输入辞退福利")]
        public double CiTuiFuLi { get; set; }

        #endregion

        #region 变动费用

        /// <summary>
        /// 办公费
        /// </summary>
        [Display(Name = "办公费")]
        [Required(ErrorMessage = "请输入办公费")]
        public double BanGongFei { get; set; }

        /// <summary>
        /// 通讯费
        /// </summary>
        [Display(Name = "通讯费")]
        [Required(ErrorMessage = "请输入通讯费")]
        public double TongXunFei { get; set; }

        /// <summary>
        /// 广宣费
        /// </summary>
        [Display(Name = "广宣费")]
        [Required(ErrorMessage = "请输入广宣费")]
        public double GuangXuanFei { get; set; }

        /// <summary>
        /// 培训费
        /// </summary>
        [Display(Name = "培训费")]
        [Required(ErrorMessage = "请输入培训费")]
        public double PeiXunFei { get; set; }

        /// <summary>
        /// 水电暖费
        /// </summary>
        [Display(Name = "水电暖费")]
        [Required(ErrorMessage = "请输入水电暖费")]
        public double ShuiDianNuanFei { get; set; }

        /// <summary>
        /// 差旅费
        /// </summary>
        [Display(Name = "差旅费")]
        [Required(ErrorMessage = "请输入差旅费")]
        public double ChaiLvFei { get; set; }

        /// <summary>
        /// 诉讼费
        /// </summary>
        [Display(Name = "诉讼费")]
        [Required(ErrorMessage = "请输入诉讼费")]
        public double SuSongFei { get; set; }

        /// <summary>
        /// 车辆使用费
        /// </summary>
        [Display(Name = "车辆使用费")]
        [Required(ErrorMessage = "请输入车辆使用费")]
        public double CheLiangShiYongFei { get; set; }

        /// <summary>
        /// 运输费
        /// </summary>
        [Display(Name = "运输费")]
        [Required(ErrorMessage = "请输入运输费")]
        public double YunShuFei { get; set; }

        /// <summary>
        /// 售后售前服务费
        /// </summary>
        [Display(Name = "售后售前服务费")]
        [Required(ErrorMessage = "请输入售后售前服务费")]
        public double ShouHouShouQianFuWuFei { get; set; }

        /// <summary>
        /// 审计费
        /// </summary>
        [Display(Name = "审计费")]
        [Required(ErrorMessage = "请输入审计费")]
        public double ShenJiFei { get; set; }

        /// <summary>
        /// 低值易耗品
        /// </summary>
        [Display(Name = "低值易耗品")]
        [Required(ErrorMessage = "请输入低值易耗品")]
        public double DiZhiYiHaoPin { get; set; }

        /// <summary>
        /// 物料消耗费
        /// </summary>
        [Display(Name = "物料消耗费")]
        [Required(ErrorMessage = "请输入物料消耗费")]
        public double WuLiaoXiaoHaoFei { get; set; }

        /// <summary>
        /// 业务招待费
        /// </summary>
        [Display(Name = "业务招待费")]
        [Required(ErrorMessage = "请输入业务招待费")]
        public double YeWuZhaoDaiFei { get; set; }

        /// <summary>
        /// 绿化保洁费用
        /// </summary>
        [Display(Name = "绿化保洁费用")]
        [Required(ErrorMessage = "请输入绿化保洁费用")]
        public double LvHuaBaoJieFeiYong { get; set; }

        /// <summary>
        /// 保险费
        /// </summary>
        [Display(Name = "保险费")]
        [Required(ErrorMessage = "请输入保险费")]
        public double BaoXianFei { get; set; }

        /// <summary>
        /// 修理费
        /// </summary>
        [Display(Name = "修理费")]
        [Required(ErrorMessage = "请输入修理费")]
        public double XiuLiFei { get; set; }

        /// <summary>
        /// 税金
        /// </summary>
        [Display(Name = "税金")]
        [Required(ErrorMessage = "请输入税金")]
        public double ShuiJin { get; set; }

        /// <summary>
        /// 咨询费/劳务费
        /// </summary>
        [Display(Name = "咨询费/劳务费")]
        [Required(ErrorMessage = "请输入咨询费/劳务费")]
        public double ZiXunFei_LaoWuFei { get; set; }

        /// <summary>
        /// 董事会费
        /// </summary>
        [Display(Name = "董事会费")]
        [Required(ErrorMessage = "请输入董事会费")]
        public double DongShiHuiFei { get; set; }

        /// <summary>
        /// 公证费
        /// </summary>
        [Display(Name = "公证费")]
        [Required(ErrorMessage = "请输入公证费")]
        public double GongZhengFei { get; set; }

        /// <summary>
        /// 排污费
        /// </summary>
        [Display(Name = "排污费")]
        [Required(ErrorMessage = "请输入排污费")]
        public double PaiWuFei { get; set; }

        /// <summary>
        /// 厂家软件使用费
        /// </summary>
        [Display(Name = "厂家软件使用费")]
        [Required(ErrorMessage = "请输入厂家软件使用费")]
        public double ChangJiaRuanJianShiYongFei { get; set; }

        /// <summary>
        /// 招标手续费
        /// </summary>
        [Display(Name = "招标手续费")]
        [Required(ErrorMessage = "请输入招标手续费")]
        public double ZhaoBiaoShouXuFei { get; set; }

        /// <summary>
        /// 会议费
        /// </summary>
        [Display(Name = "会议费")]
        [Required(ErrorMessage = "请输入会议费")]
        public double HuiYiFei { get; set; }

        /// <summary>
        /// 服务费
        /// </summary>
        [Display(Name = "服务费")]
        [Required(ErrorMessage = "请输入服务费")]
        public double FuWuFei { get; set; }

        /// <summary>
        /// 其他
        /// </summary>
        [Display(Name = "其他")]
        [Required(ErrorMessage = "请输入其他")]
        public double QiTa { get; set; }

        #endregion

        #region 固定费用

        /// <summary>
        /// 折旧费
        /// </summary>
        [Display(Name = "折旧费")]
        [Required(ErrorMessage = "请输入折旧费")]
        public double ZheJiuFei { get; set; }

        /// <summary>
        /// 无形资产推销
        /// </summary>
        [Display(Name = "无形资产推销")]
        [Required(ErrorMessage = "请输入无形资产推销")]
        public double WuXingZiChanTanFei { get; set; }

        /// <summary>
        /// 长期待摊费用摊销
        /// </summary>
        [Display(Name = "长期待摊费用摊销")]
        [Required(ErrorMessage = "请输入长期待摊费用摊销")]
        public double ChangQiDaiTanFeiYongTanXiao { get; set; }

        /// <summary>
        /// 租赁物管费
        /// </summary>
        [Display(Name = "租赁物管费")]
        [Required(ErrorMessage = "请输入租蘋物管费")]
        public double ZuPingWuGuanFei { get; set; }

        #endregion

        #region 财务费用

        /// <summary>
        /// 利息收入
        /// </summary>
        [Display(Name = "利息收入")]
        [Required(ErrorMessage = "请输入利息收入")]
        public double LiXiShouRu { get; set; }

        /// <summary>
        /// 利息支出
        /// </summary>
        [Display(Name = "利息支出")]
        [Required(ErrorMessage = "请输入利息支出")]
        public double LiXiZhiChu { get; set; }

        /// <summary>
        /// 手续费
        /// </summary>
        [Display(Name = "手续费")]
        [Required(ErrorMessage = "请输入手续费")]
        public double ShouXuFei { get; set; }

        /// <summary>
        /// 担保费
        /// </summary>
        [Display(Name = "担保费")]
        [Required(ErrorMessage = "请输入担保费")]
        public double DanBaoFei { get; set; }

        /// <summary>
        /// 其他
        /// </summary>
        [Display(Name = "其他")]
        [Required(ErrorMessage = "请输入其他")]
        public double QiTa_CaiWuFeiYong { get; set; }

        #endregion
    }
}
