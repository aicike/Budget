using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using System.Data;
using Entity;

namespace Budget.Controllers
{
    /// <summary>
    /// 损益预算 控制器
    /// </summary>
    public class ProfitLossController : BaseController
    {
        //损益预算首页(公司列表)
        public ActionResult Index()
        {
            ParticularYearModel pyearModel = new ParticularYearModel();
            var list = pyearModel.List().OrderByDescending(a => a.ID).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Year"); //年
            dt.Columns.Add("YearID"); //年ID
            dt.Columns.Add("PMID"); //明细主表ID
            dt.Columns.Add("Type"); // 0：已上报 ，1：未上报，2：未填写预算

            foreach (var item in list)
            {
                DataRow row = dt.NewRow();
                row["Year"] = item.Year + "年损益预算";
                row["YearID"] = item.ID;
                if (item.ProfitLoss_Main != null)
                {
                    var profitloss_main = item.ProfitLoss_Main.Where(a => a.CompanyID == LoginAccount.ID);
                    if (profitloss_main.Count() > 0)
                    {
                        if (profitloss_main.FirstOrDefault().IsReport)
                        {
                            row["Type"] = 0;
                            row["PMID"] = profitloss_main.FirstOrDefault().ID;
                        }
                        else
                        {
                            row["Type"] = 1;
                            row["PMID"] = profitloss_main.FirstOrDefault().ID;
                        }
                    }
                    else
                    {
                        row["Type"] = 2;
                    }
                }
                else
                {
                    row["Type"] = 2;
                }

                dt.Rows.Add(row);
            }
            return View(dt);
        }

        //损益预算首页(集团列表)
        public ActionResult GroupIndex()
        {
            ParticularYearModel pyearModel = new ParticularYearModel();
            var list = pyearModel.List().OrderByDescending(a => a.ID).ToList();

            return View(list);
        }

        //损益预算统计界面(集团)
        public ActionResult GroupStatistics(int YearID)
        {
            ParticularYearModel pyearModel = new ParticularYearModel();
            var pyear = pyearModel.Get(YearID);
            ViewBag.Year = pyear.Year;
            ViewBag.YearID = YearID;

            ProfitLoss_MainModel plMModel = new ProfitLoss_MainModel();
            //上报的明细
            var PLMain = plMModel.GetMainInfo_ByYearID(YearID).Where(a => a.IsReport == true);
            //获取所有上报明细主表ID
            var PMIDs = PLMain.Select(a => a.ID).ToArray();
            //获取所有上报公司ID
            var CIDs = PLMain.Select(a => a.CompanyID).ToArray();
            //获取未上报公司
            CompanyModel CModel = new CompanyModel();
            var Ncompany = CModel.List().Where(a => CIDs.Contains(a.ID) == false).ToList();
            ViewBag.Ncompany = Ncompany;
            //获取所有明细
            ProfitLoss_DetailedModel pldModel = new ProfitLoss_DetailedModel();
            var strpmids = PLMain.Select(a => a.ID).ToList().ConvertToString(",");
            DataTable dt = new DataTable();
            if (strpmids == "")
            {
                return View(dt);
            }
            dt = pldModel.GetStatistics_ByMainID(strpmids);
            DataTable dtTitle = new DataTable();
            dtTitle.Columns.Add("CompanyID");
            dtTitle.Columns.Add("CompanyName");
            dtTitle.Columns.Add("XiaoShouShuLiang");
            dtTitle.Columns.Add("XinCheXiaoShouShuLiang");
            dtTitle.Columns.Add("WeiXiuJinChangTaiCi");
            dtTitle.Columns.Add("FenQiShuLiang");
            dtTitle.Columns.Add("XinBaoShuLiang");
            dtTitle.Columns.Add("XuBaoShuLiang");
            dtTitle.Columns.Add("YanBaoShuLiang");
            dtTitle.Columns.Add("GuaPaiShuLiang");
            dtTitle.Columns.Add("ErShouCheXiaoShouShuLiang");
            dtTitle.Columns.Add("ZhuYingYeWuShouRu");
            dtTitle.Columns.Add("ZhuYingShouRu_ZhengChe");
            dtTitle.Columns.Add("ZhuYingShouRu_ShouHouWeiXiu");
            dtTitle.Columns.Add("ZhuYingShouRu_WeiXiuPeiJian");
            dtTitle.Columns.Add("ZhuYingShouRu_GongShi");
            dtTitle.Columns.Add("ZhuYingShouRu_ZhuangShiZhuangHuang");
            dtTitle.Columns.Add("ZhuYingShouRu_YongJin");
            dtTitle.Columns.Add("ZhuYingShouRu_FenQi");
            dtTitle.Columns.Add("ZhuYingShouRu_BaoXian");
            dtTitle.Columns.Add("ZhuYingShouRu_XinBao");
            dtTitle.Columns.Add("ZhuYingShouRu_XuBao");
            dtTitle.Columns.Add("ZhuYingShouRu_YanBao");
            dtTitle.Columns.Add("ZhuYingShouRu_GuaPai");
            dtTitle.Columns.Add("ZhuYingShouRu_ErShouChe");
            dtTitle.Columns.Add("ZhuYingShouRu_QiTa");
            dtTitle.Columns.Add("ZhuYingYeWuChengBen");
            dtTitle.Columns.Add("ZhuYingChengBen_ZhengChe");
            dtTitle.Columns.Add("ZhuYingChengBen_ShouHouWeiXiu");
            dtTitle.Columns.Add("ZhuYingChengBen_WeiXiuPeiJian");
            dtTitle.Columns.Add("ZhuYingChengBen_GongShi");
            dtTitle.Columns.Add("ZhuYingChengBen_ZhuangShiZhuangHuang");
            dtTitle.Columns.Add("ZhuYingChengBen_YongJin");
            dtTitle.Columns.Add("ZhuYingChengBen_FenQi");
            dtTitle.Columns.Add("ZhuYingChengBen_BaoXian");
            dtTitle.Columns.Add("ZhuYingChengBen_XinBao");
            dtTitle.Columns.Add("ZhuYingChengBen_XuBao");
            dtTitle.Columns.Add("ZhuYingChengBen_YanBao");
            dtTitle.Columns.Add("ZhuYingChengBen_GuaPai");
            dtTitle.Columns.Add("ZhuYingChengBen_ErShouChe");
            dtTitle.Columns.Add("ZhuYingChengBen_QiTa");
            dtTitle.Columns.Add("MaoLi");
            dtTitle.Columns.Add("MaoLi_ZhengChe");
            dtTitle.Columns.Add("MaoLi_WeiXiu");
            dtTitle.Columns.Add("MaoLi_ZhuangShiZhuangHuang");
            dtTitle.Columns.Add("MaoLi_YongJin");
            dtTitle.Columns.Add("ZhuYingYeWuShueiJinJiFuJia");
            dtTitle.Columns.Add("ZhuYingYeWuFuJiaShuiHouMaoLi");
            dtTitle.Columns.Add("QiTaYeWuShouRu");
            dtTitle.Columns.Add("QiTaYeWuChengBen");
            dtTitle.Columns.Add("QiTaYeWuShuiJinJiFuJia");
            dtTitle.Columns.Add("QiTaYeWuLiRun");
            dtTitle.Columns.Add("XiaoShouJiGuanLiFeiYong");
            dtTitle.Columns.Add("XiShueiQianLiRun");
            dtTitle.Columns.Add("CaiWuFeiYong");
            dtTitle.Columns.Add("YingYeLiRun");
            dtTitle.Columns.Add("ZiChanJianZhiSunShi");
            dtTitle.Columns.Add("GongYunJiaZhiBianDongShouYi");
            dtTitle.Columns.Add("TouZiShouYi");
            dtTitle.Columns.Add("YingYeWaiShouZhiJingE");
            dtTitle.Columns.Add("LiRunZongE");
            dtTitle.Columns.Add("SuoDeShui");
            dtTitle.Columns.Add("ShueiHouLiRun");
            dtTitle.Columns.Add("ShaoShuGuDongSunYi");
            dtTitle.Columns.Add("JingLiRun");

            DataRow row = dtTitle.NewRow();
            row["CompanyID"] = "";
            row["CompanyName"] = "项目";
            row["XiaoShouShuLiang"] = "销售数量";
            row["XinCheXiaoShouShuLiang"] = "新车销售数量";
            row["WeiXiuJinChangTaiCi"] = "维修进场台次";
            row["FenQiShuLiang"] = "分期数量";
            row["XinBaoShuLiang"] = "新保数量";
            row["XuBaoShuLiang"] = "续保数量";
            row["YanBaoShuLiang"] = "延保数量";
            row["GuaPaiShuLiang"] = "挂牌数量";
            row["ErShouCheXiaoShouShuLiang"] = "二手车销售数量";
            row["ZhuYingYeWuShouRu"] = "请输入主营业务收入";
            row["ZhuYingShouRu_ZhengChe"] = "整车";
            row["ZhuYingShouRu_ShouHouWeiXiu"] = "售后维修";
            row["ZhuYingShouRu_WeiXiuPeiJian"] = "维修配件";
            row["ZhuYingShouRu_GongShi"] = "工时";
            row["ZhuYingShouRu_ZhuangShiZhuangHuang"] = "装饰装潢";
            row["ZhuYingShouRu_YongJin"] = "佣金";
            row["ZhuYingShouRu_FenQi"] = "分期";
            row["ZhuYingShouRu_BaoXian"] = "保险";
            row["ZhuYingShouRu_XinBao"] = "新保";
            row["ZhuYingShouRu_XuBao"] = "续保";
            row["ZhuYingShouRu_YanBao"] = "延保";
            row["ZhuYingShouRu_GuaPai"] = "挂牌";
            row["ZhuYingShouRu_ErShouChe"] = "二手车";
            row["ZhuYingShouRu_QiTa"] = "其他";
            row["ZhuYingYeWuChengBen"] = "减：主营业务成本";
            row["ZhuYingChengBen_ZhengChe"] = "整车";
            row["ZhuYingChengBen_ShouHouWeiXiu"] = "售后维修";
            row["ZhuYingChengBen_WeiXiuPeiJian"] = "维修配件";
            row["ZhuYingChengBen_GongShi"] = "工时";
            row["ZhuYingChengBen_ZhuangShiZhuangHuang"] = "装饰装潢";
            row["ZhuYingChengBen_YongJin"] = "佣金";
            row["ZhuYingChengBen_FenQi"] = "分期";
            row["ZhuYingChengBen_BaoXian"] = "保险";
            row["ZhuYingChengBen_XinBao"] = "新保";
            row["ZhuYingChengBen_XuBao"] = "续保";
            row["ZhuYingChengBen_YanBao"] = "延保";
            row["ZhuYingChengBen_GuaPai"] = "挂牌";
            row["ZhuYingChengBen_ErShouChe"] = "二手车";
            row["ZhuYingChengBen_QiTa"] = "其他";
            row["MaoLi"] = "毛利";
            row["MaoLi_ZhengChe"] = "整车";
            row["MaoLi_WeiXiu"] = "维修";
            row["MaoLi_ZhuangShiZhuangHuang"] = "装饰装潢";
            row["MaoLi_YongJin"] = "佣金";
            row["ZhuYingYeWuShueiJinJiFuJia"] = "主营业务税金及附加";
            row["ZhuYingYeWuFuJiaShuiHouMaoLi"] = "主营业务附加税后毛利";
            row["QiTaYeWuShouRu"] = "其他业务收入";
            row["QiTaYeWuChengBen"] = "其他业务成本";
            row["QiTaYeWuShuiJinJiFuJia"] = "其他业务税金及附加";
            row["QiTaYeWuLiRun"] = "其他业务利润";
            row["XiaoShouJiGuanLiFeiYong"] = "销售及管理费用";
            row["XiShueiQianLiRun"] = "息税前利润";
            row["CaiWuFeiYong"] = "财务费用";
            row["YingYeLiRun"] = "营业利润";
            row["ZiChanJianZhiSunShi"] = "资产减值损失";
            row["GongYunJiaZhiBianDongShouYi"] = "公允价值变动收益";
            row["TouZiShouYi"] = "投资收益";
            row["YingYeWaiShouZhiJingE"] = "营业外收支净额";
            row["LiRunZongE"] = "利润总额";
            row["SuoDeShui"] = "所得税";
            row["ShueiHouLiRun"] = "税后利润";
            row["ShaoShuGuDongSunYi"] = "少数股东损益";
            row["JingLiRun"] = "净利润";

            dtTitle.Rows.Add(row);
            ViewBag.DtTitle = dtTitle;
            return View(dt);
        }

        //损益预算公司预算表明细（集团）
        public ActionResult CompanyDetail(int ComPanyID, int YearID)
        {
            ParticularYearModel PyearModel = new ParticularYearModel();
            var pyear = PyearModel.Get(YearID);
            ViewBag.Year = pyear.Year;
            ViewBag.YearID = YearID;

            CompanyModel CModel = new CompanyModel();
            var company = CModel.Get(ComPanyID);
            ViewBag.CompanyID = ComPanyID;
            ViewBag.CompanyName = company.Name;
            ProfitLoss_DetailedModel PldModel = new ProfitLoss_DetailedModel();
            var list = PldModel.GetDetailed_ByCompanyID(ComPanyID, YearID);


            //数据添加到DataTable中
            DataTable dtInfo = SetDt_Detail();
            foreach (var item in list)
            {
                DataRow infoRow = dtInfo.NewRow();
                infoRow["Month"] = item.Month + "月份";
                infoRow["XiaoShouShuLiang"] = item.XiaoShouShuLiang;
                infoRow["XinCheXiaoShouShuLiang"] = item.XinCheXiaoShouShuLiang;
                infoRow["WeiXiuJinChangTaiCi"] = item.WeiXiuJinChangTaiCi;
                infoRow["FenQiShuLiang"] = item.FenQiShuLiang;
                infoRow["XinBaoShuLiang"] = item.XinBaoShuLiang;
                infoRow["XuBaoShuLiang"] = item.XuBaoShuLiang;
                infoRow["YanBaoShuLiang"] = item.YanBaoShuLiang;
                infoRow["GuaPaiShuLiang"] = item.GuaPaiShuLiang;
                infoRow["ErShouCheXiaoShouShuLiang"] = item.ErShouCheXiaoShouShuLiang;
                infoRow["ZhuYingYeWuShouRu"] = item.ZhuYingYeWuShouRu;
                infoRow["ZhuYingShouRu_ZhengChe"] = item.ZhuYingShouRu_ZhengChe;
                infoRow["ZhuYingShouRu_ShouHouWeiXiu"] = item.ZhuYingShouRu_ShouHouWeiXiu;
                infoRow["ZhuYingShouRu_WeiXiuPeiJian"] = item.ZhuYingShouRu_WeiXiuPeiJian;
                infoRow["ZhuYingShouRu_GongShi"] = item.ZhuYingShouRu_GongShi;
                infoRow["ZhuYingShouRu_ZhuangShiZhuangHuang"] = item.ZhuYingShouRu_ZhuangShiZhuangHuang;
                infoRow["ZhuYingShouRu_YongJin"] = item.ZhuYingShouRu_YongJin;
                infoRow["ZhuYingShouRu_FenQi"] = item.ZhuYingShouRu_FenQi;
                infoRow["ZhuYingShouRu_BaoXian"] = item.ZhuYingShouRu_BaoXian;
                infoRow["ZhuYingShouRu_XinBao"] = item.ZhuYingShouRu_XinBao;
                infoRow["ZhuYingShouRu_XuBao"] = item.ZhuYingShouRu_XuBao;
                infoRow["ZhuYingShouRu_YanBao"] = item.ZhuYingShouRu_YanBao;
                infoRow["ZhuYingShouRu_GuaPai"] = item.ZhuYingShouRu_GuaPai;
                infoRow["ZhuYingShouRu_ErShouChe"] = item.ZhuYingShouRu_ErShouChe;
                infoRow["ZhuYingShouRu_QiTa"] = item.ZhuYingShouRu_QiTa;
                infoRow["ZhuYingYeWuChengBen"] = item.ZhuYingYeWuChengBen;
                infoRow["ZhuYingChengBen_ZhengChe"] = item.ZhuYingChengBen_ZhengChe;
                infoRow["ZhuYingChengBen_ShouHouWeiXiu"] = item.ZhuYingChengBen_ShouHouWeiXiu;
                infoRow["ZhuYingChengBen_WeiXiuPeiJian"] = item.ZhuYingChengBen_WeiXiuPeiJian;
                infoRow["ZhuYingChengBen_GongShi"] = item.ZhuYingChengBen_GongShi;
                infoRow["ZhuYingChengBen_ZhuangShiZhuangHuang"] = item.ZhuYingChengBen_ZhuangShiZhuangHuang;
                infoRow["ZhuYingChengBen_YongJin"] = item.ZhuYingChengBen_YongJin;
                infoRow["ZhuYingChengBen_FenQi"] = item.ZhuYingChengBen_FenQi;
                infoRow["ZhuYingChengBen_BaoXian"] = item.ZhuYingChengBen_BaoXian;
                infoRow["ZhuYingChengBen_XinBao"] = item.ZhuYingChengBen_XinBao;
                infoRow["ZhuYingChengBen_XuBao"] = item.ZhuYingChengBen_XuBao;
                infoRow["ZhuYingChengBen_YanBao"] = item.ZhuYingChengBen_YanBao;
                infoRow["ZhuYingChengBen_GuaPai"] = item.ZhuYingChengBen_GuaPai;
                infoRow["ZhuYingChengBen_ErShouChe"] = item.ZhuYingChengBen_ErShouChe;
                infoRow["ZhuYingChengBen_QiTa"] = item.ZhuYingChengBen_QiTa;
                infoRow["MaoLi"] = item.MaoLi;
                infoRow["MaoLi_ZhengChe"] = item.MaoLi_ZhengChe;
                infoRow["MaoLi_WeiXiu"] = item.MaoLi_WeiXiu;
                infoRow["MaoLi_ZhuangShiZhuangHuang"] = item.MaoLi_ZhuangShiZhuangHuang;
                infoRow["MaoLi_YongJin"] = item.MaoLi_YongJin;
                infoRow["ZhuYingYeWuShueiJinJiFuJia"] = item.ZhuYingYeWuShueiJinJiFuJia;
                infoRow["ZhuYingYeWuFuJiaShuiHouMaoLi"] = item.ZhuYingYeWuFuJiaShuiHouMaoLi;
                infoRow["QiTaYeWuShouRu"] = item.QiTaYeWuShouRu;
                infoRow["QiTaYeWuChengBen"] = item.QiTaYeWuChengBen;
                infoRow["QiTaYeWuShuiJinJiFuJia"] = item.QiTaYeWuShuiJinJiFuJia;
                infoRow["QiTaYeWuLiRun"] = item.QiTaYeWuLiRun;
                infoRow["XiaoShouJiGuanLiFeiYong"] = item.XiaoShouJiGuanLiFeiYong;
                infoRow["XiShueiQianLiRun"] = item.XiShueiQianLiRun;
                infoRow["CaiWuFeiYong"] = item.CaiWuFeiYong;
                infoRow["YingYeLiRun"] = item.YingYeLiRun;
                infoRow["ZiChanJianZhiSunShi"] = item.ZiChanJianZhiSunShi;
                infoRow["GongYunJiaZhiBianDongShouYi"] = item.GongYunJiaZhiBianDongShouYi;
                infoRow["TouZiShouYi"] = item.TouZiShouYi;
                infoRow["YingYeWaiShouZhiJingE"] = item.YingYeWaiShouZhiJingE;
                infoRow["LiRunZongE"] = item.LiRunZongE;
                infoRow["SuoDeShui"] = item.SuoDeShui;
                infoRow["ShueiHouLiRun"] = item.ShueiHouLiRun;
                infoRow["ShaoShuGuDongSunYi"] = item.ShaoShuGuDongSunYi;
                infoRow["JingLiRun"] = item.JingLiRun;

                dtInfo.Rows.Add(infoRow);
            };
            #region 数据汇总
            DataRow RowHZ = dtInfo.NewRow();
            RowHZ["Month"] = "累计";
            RowHZ["XiaoShouShuLiang"] = list.Sum(a => a.XiaoShouShuLiang);
            RowHZ["XinCheXiaoShouShuLiang"] = list.Sum(a => a.XinCheXiaoShouShuLiang);
            RowHZ["WeiXiuJinChangTaiCi"] = list.Sum(a => a.WeiXiuJinChangTaiCi);
            RowHZ["FenQiShuLiang"] = list.Sum(a => a.FenQiShuLiang);
            RowHZ["XinBaoShuLiang"] = list.Sum(a => a.XinBaoShuLiang);
            RowHZ["XuBaoShuLiang"] = list.Sum(a => a.XuBaoShuLiang);
            RowHZ["YanBaoShuLiang"] = list.Sum(a => a.YanBaoShuLiang);
            RowHZ["GuaPaiShuLiang"] = list.Sum(a => a.GuaPaiShuLiang);
            RowHZ["ErShouCheXiaoShouShuLiang"] = list.Sum(a => a.ErShouCheXiaoShouShuLiang);
            RowHZ["ZhuYingYeWuShouRu"] = list.Sum(a => a.ZhuYingYeWuShouRu);
            RowHZ["ZhuYingShouRu_ZhengChe"] = list.Sum(a => a.ZhuYingShouRu_ZhengChe);
            RowHZ["ZhuYingShouRu_ShouHouWeiXiu"] = list.Sum(a => a.ZhuYingShouRu_ShouHouWeiXiu);
            RowHZ["ZhuYingShouRu_WeiXiuPeiJian"] = list.Sum(a => a.ZhuYingShouRu_WeiXiuPeiJian);
            RowHZ["ZhuYingShouRu_GongShi"] = list.Sum(a => a.ZhuYingShouRu_GongShi);
            RowHZ["ZhuYingShouRu_ZhuangShiZhuangHuang"] = list.Sum(a => a.ZhuYingShouRu_ZhuangShiZhuangHuang);
            RowHZ["ZhuYingShouRu_YongJin"] = list.Sum(a => a.ZhuYingShouRu_YongJin);
            RowHZ["ZhuYingShouRu_FenQi"] = list.Sum(a => a.ZhuYingShouRu_FenQi);
            RowHZ["ZhuYingShouRu_BaoXian"] = list.Sum(a => a.ZhuYingShouRu_BaoXian);
            RowHZ["ZhuYingShouRu_XinBao"] = list.Sum(a => a.ZhuYingShouRu_XinBao);
            RowHZ["ZhuYingShouRu_XuBao"] = list.Sum(a => a.ZhuYingShouRu_XuBao);
            RowHZ["ZhuYingShouRu_YanBao"] = list.Sum(a => a.ZhuYingShouRu_YanBao);
            RowHZ["ZhuYingShouRu_GuaPai"] = list.Sum(a => a.ZhuYingShouRu_GuaPai);
            RowHZ["ZhuYingShouRu_ErShouChe"] = list.Sum(a => a.ZhuYingShouRu_ErShouChe);
            RowHZ["ZhuYingShouRu_QiTa"] = list.Sum(a => a.ZhuYingShouRu_QiTa);
            RowHZ["ZhuYingYeWuChengBen"] = list.Sum(a => a.ZhuYingYeWuChengBen);
            RowHZ["ZhuYingChengBen_ZhengChe"] = list.Sum(a => a.ZhuYingChengBen_ZhengChe);
            RowHZ["ZhuYingChengBen_ShouHouWeiXiu"] = list.Sum(a => a.ZhuYingChengBen_ShouHouWeiXiu);
            RowHZ["ZhuYingChengBen_WeiXiuPeiJian"] = list.Sum(a => a.ZhuYingChengBen_WeiXiuPeiJian);
            RowHZ["ZhuYingChengBen_GongShi"] = list.Sum(a => a.ZhuYingChengBen_GongShi);
            RowHZ["ZhuYingChengBen_ZhuangShiZhuangHuang"] = list.Sum(a => a.ZhuYingChengBen_ZhuangShiZhuangHuang);
            RowHZ["ZhuYingChengBen_YongJin"] = list.Sum(a => a.ZhuYingChengBen_YongJin);
            RowHZ["ZhuYingChengBen_FenQi"] = list.Sum(a => a.ZhuYingChengBen_FenQi);
            RowHZ["ZhuYingChengBen_BaoXian"] = list.Sum(a => a.ZhuYingChengBen_BaoXian);
            RowHZ["ZhuYingChengBen_XinBao"] = list.Sum(a => a.ZhuYingChengBen_XinBao);
            RowHZ["ZhuYingChengBen_XuBao"] = list.Sum(a => a.ZhuYingChengBen_XuBao);
            RowHZ["ZhuYingChengBen_YanBao"] = list.Sum(a => a.ZhuYingChengBen_YanBao);
            RowHZ["ZhuYingChengBen_GuaPai"] = list.Sum(a => a.ZhuYingChengBen_GuaPai);
            RowHZ["ZhuYingChengBen_ErShouChe"] = list.Sum(a => a.ZhuYingChengBen_ErShouChe);
            RowHZ["ZhuYingChengBen_QiTa"] = list.Sum(a => a.ZhuYingChengBen_QiTa);
            RowHZ["MaoLi"] = list.Sum(a => a.MaoLi);
            RowHZ["MaoLi_ZhengChe"] = list.Sum(a => a.MaoLi_ZhengChe);
            RowHZ["MaoLi_WeiXiu"] = list.Sum(a => a.MaoLi_WeiXiu);
            RowHZ["MaoLi_ZhuangShiZhuangHuang"] = list.Sum(a => a.MaoLi_ZhuangShiZhuangHuang);
            RowHZ["MaoLi_YongJin"] = list.Sum(a => a.MaoLi_YongJin);
            RowHZ["ZhuYingYeWuShueiJinJiFuJia"] = list.Sum(a => a.ZhuYingYeWuShueiJinJiFuJia);
            RowHZ["ZhuYingYeWuFuJiaShuiHouMaoLi"] = list.Sum(a => a.ZhuYingYeWuFuJiaShuiHouMaoLi);
            RowHZ["QiTaYeWuShouRu"] = list.Sum(a => a.QiTaYeWuShouRu);
            RowHZ["QiTaYeWuChengBen"] = list.Sum(a => a.QiTaYeWuChengBen);
            RowHZ["QiTaYeWuShuiJinJiFuJia"] = list.Sum(a => a.QiTaYeWuShuiJinJiFuJia);
            RowHZ["QiTaYeWuLiRun"] = list.Sum(a => a.QiTaYeWuLiRun);
            RowHZ["XiaoShouJiGuanLiFeiYong"] = list.Sum(a => a.XiaoShouJiGuanLiFeiYong);
            RowHZ["XiShueiQianLiRun"] = list.Sum(a => a.XiShueiQianLiRun);
            RowHZ["CaiWuFeiYong"] = list.Sum(a => a.CaiWuFeiYong);
            RowHZ["YingYeLiRun"] = list.Sum(a => a.YingYeLiRun);
            RowHZ["ZiChanJianZhiSunShi"] = list.Sum(a => a.ZiChanJianZhiSunShi);
            RowHZ["GongYunJiaZhiBianDongShouYi"] = list.Sum(a => a.GongYunJiaZhiBianDongShouYi);
            RowHZ["TouZiShouYi"] = list.Sum(a => a.TouZiShouYi);
            RowHZ["YingYeWaiShouZhiJingE"] = list.Sum(a => a.YingYeWaiShouZhiJingE);
            RowHZ["LiRunZongE"] = list.Sum(a => a.LiRunZongE);
            RowHZ["SuoDeShui"] = list.Sum(a => a.SuoDeShui);
            RowHZ["ShueiHouLiRun"] = list.Sum(a => a.ShueiHouLiRun);
            RowHZ["ShaoShuGuDongSunYi"] = list.Sum(a => a.ShaoShuGuDongSunYi);
            RowHZ["JingLiRun"] = list.Sum(a => a.JingLiRun);


            dtInfo.Rows.Add(RowHZ);
            #endregion

            #region 纵向表头
            DataTable dtTitle = SetDt_Detail();
            DataRow row = dtTitle.NewRow();
            row["Month"] = "项目";
            row["XiaoShouShuLiang"] = "销售数量";
            row["XinCheXiaoShouShuLiang"] = "新车销售数量";
            row["WeiXiuJinChangTaiCi"] = "维修进场台次";
            row["FenQiShuLiang"] = "分期数量";
            row["XinBaoShuLiang"] = "新保数量";
            row["XuBaoShuLiang"] = "续保数量";
            row["YanBaoShuLiang"] = "延保数量";
            row["GuaPaiShuLiang"] = "挂牌数量";
            row["ErShouCheXiaoShouShuLiang"] = "二手车销售数量";
            row["ZhuYingYeWuShouRu"] = "请输入主营业务收入";
            row["ZhuYingShouRu_ZhengChe"] = "整车";
            row["ZhuYingShouRu_ShouHouWeiXiu"] = "售后维修";
            row["ZhuYingShouRu_WeiXiuPeiJian"] = "维修配件";
            row["ZhuYingShouRu_GongShi"] = "工时";
            row["ZhuYingShouRu_ZhuangShiZhuangHuang"] = "装饰装潢";
            row["ZhuYingShouRu_YongJin"] = "佣金";
            row["ZhuYingShouRu_FenQi"] = "分期";
            row["ZhuYingShouRu_BaoXian"] = "保险";
            row["ZhuYingShouRu_XinBao"] = "新保";
            row["ZhuYingShouRu_XuBao"] = "续保";
            row["ZhuYingShouRu_YanBao"] = "延保";
            row["ZhuYingShouRu_GuaPai"] = "挂牌";
            row["ZhuYingShouRu_ErShouChe"] = "二手车";
            row["ZhuYingShouRu_QiTa"] = "其他";
            row["ZhuYingYeWuChengBen"] = "减：主营业务成本";
            row["ZhuYingChengBen_ZhengChe"] = "整车";
            row["ZhuYingChengBen_ShouHouWeiXiu"] = "售后维修";
            row["ZhuYingChengBen_WeiXiuPeiJian"] = "维修配件";
            row["ZhuYingChengBen_GongShi"] = "工时";
            row["ZhuYingChengBen_ZhuangShiZhuangHuang"] = "装饰装潢";
            row["ZhuYingChengBen_YongJin"] = "佣金";
            row["ZhuYingChengBen_FenQi"] = "分期";
            row["ZhuYingChengBen_BaoXian"] = "保险";
            row["ZhuYingChengBen_XinBao"] = "新保";
            row["ZhuYingChengBen_XuBao"] = "续保";
            row["ZhuYingChengBen_YanBao"] = "延保";
            row["ZhuYingChengBen_GuaPai"] = "挂牌";
            row["ZhuYingChengBen_ErShouChe"] = "二手车";
            row["ZhuYingChengBen_QiTa"] = "其他";
            row["MaoLi"] = "毛利";
            row["MaoLi_ZhengChe"] = "整车";
            row["MaoLi_WeiXiu"] = "维修";
            row["MaoLi_ZhuangShiZhuangHuang"] = "装饰装潢";
            row["MaoLi_YongJin"] = "佣金";
            row["ZhuYingYeWuShueiJinJiFuJia"] = "主营业务税金及附加";
            row["ZhuYingYeWuFuJiaShuiHouMaoLi"] = "主营业务附加税后毛利";
            row["QiTaYeWuShouRu"] = "其他业务收入";
            row["QiTaYeWuChengBen"] = "其他业务成本";
            row["QiTaYeWuShuiJinJiFuJia"] = "其他业务税金及附加";
            row["QiTaYeWuLiRun"] = "其他业务利润";
            row["XiaoShouJiGuanLiFeiYong"] = "销售及管理费用";
            row["XiShueiQianLiRun"] = "息税前利润";
            row["CaiWuFeiYong"] = "财务费用";
            row["YingYeLiRun"] = "营业利润";
            row["ZiChanJianZhiSunShi"] = "资产减值损失";
            row["GongYunJiaZhiBianDongShouYi"] = "公允价值变动收益";
            row["TouZiShouYi"] = "投资收益";
            row["YingYeWaiShouZhiJingE"] = "营业外收支净额";
            row["LiRunZongE"] = "利润总额";
            row["SuoDeShui"] = "所得税";
            row["ShueiHouLiRun"] = "税后利润";
            row["ShaoShuGuDongSunYi"] = "少数股东损益";
            row["JingLiRun"] = "净利润";

            dtTitle.Rows.Add(row);
            ViewBag.DtTitle = dtTitle;
            #endregion

            return View(dtInfo);
        }

        //初始化 明细表格
        public DataTable SetDt_Detail()
        {
            DataTable dtTitle = new DataTable();
            dtTitle.Columns.Add("Month");
            dtTitle.Columns.Add("XiaoShouShuLiang");
            dtTitle.Columns.Add("XinCheXiaoShouShuLiang");
            dtTitle.Columns.Add("WeiXiuJinChangTaiCi");
            dtTitle.Columns.Add("FenQiShuLiang");
            dtTitle.Columns.Add("XinBaoShuLiang");
            dtTitle.Columns.Add("XuBaoShuLiang");
            dtTitle.Columns.Add("YanBaoShuLiang");
            dtTitle.Columns.Add("GuaPaiShuLiang");
            dtTitle.Columns.Add("ErShouCheXiaoShouShuLiang");
            dtTitle.Columns.Add("ZhuYingYeWuShouRu");
            dtTitle.Columns.Add("ZhuYingShouRu_ZhengChe");
            dtTitle.Columns.Add("ZhuYingShouRu_ShouHouWeiXiu");
            dtTitle.Columns.Add("ZhuYingShouRu_WeiXiuPeiJian");
            dtTitle.Columns.Add("ZhuYingShouRu_GongShi");
            dtTitle.Columns.Add("ZhuYingShouRu_ZhuangShiZhuangHuang");
            dtTitle.Columns.Add("ZhuYingShouRu_YongJin");
            dtTitle.Columns.Add("ZhuYingShouRu_FenQi");
            dtTitle.Columns.Add("ZhuYingShouRu_BaoXian");
            dtTitle.Columns.Add("ZhuYingShouRu_XinBao");
            dtTitle.Columns.Add("ZhuYingShouRu_XuBao");
            dtTitle.Columns.Add("ZhuYingShouRu_YanBao");
            dtTitle.Columns.Add("ZhuYingShouRu_GuaPai");
            dtTitle.Columns.Add("ZhuYingShouRu_ErShouChe");
            dtTitle.Columns.Add("ZhuYingShouRu_QiTa");
            dtTitle.Columns.Add("ZhuYingYeWuChengBen");
            dtTitle.Columns.Add("ZhuYingChengBen_ZhengChe");
            dtTitle.Columns.Add("ZhuYingChengBen_ShouHouWeiXiu");
            dtTitle.Columns.Add("ZhuYingChengBen_WeiXiuPeiJian");
            dtTitle.Columns.Add("ZhuYingChengBen_GongShi");
            dtTitle.Columns.Add("ZhuYingChengBen_ZhuangShiZhuangHuang");
            dtTitle.Columns.Add("ZhuYingChengBen_YongJin");
            dtTitle.Columns.Add("ZhuYingChengBen_FenQi");
            dtTitle.Columns.Add("ZhuYingChengBen_BaoXian");
            dtTitle.Columns.Add("ZhuYingChengBen_XinBao");
            dtTitle.Columns.Add("ZhuYingChengBen_XuBao");
            dtTitle.Columns.Add("ZhuYingChengBen_YanBao");
            dtTitle.Columns.Add("ZhuYingChengBen_GuaPai");
            dtTitle.Columns.Add("ZhuYingChengBen_ErShouChe");
            dtTitle.Columns.Add("ZhuYingChengBen_QiTa");
            dtTitle.Columns.Add("MaoLi");
            dtTitle.Columns.Add("MaoLi_ZhengChe");
            dtTitle.Columns.Add("MaoLi_WeiXiu");
            dtTitle.Columns.Add("MaoLi_ZhuangShiZhuangHuang");
            dtTitle.Columns.Add("MaoLi_YongJin");
            dtTitle.Columns.Add("ZhuYingYeWuShueiJinJiFuJia");
            dtTitle.Columns.Add("ZhuYingYeWuFuJiaShuiHouMaoLi");
            dtTitle.Columns.Add("QiTaYeWuShouRu");
            dtTitle.Columns.Add("QiTaYeWuChengBen");
            dtTitle.Columns.Add("QiTaYeWuShuiJinJiFuJia");
            dtTitle.Columns.Add("QiTaYeWuLiRun");
            dtTitle.Columns.Add("XiaoShouJiGuanLiFeiYong");
            dtTitle.Columns.Add("XiShueiQianLiRun");
            dtTitle.Columns.Add("CaiWuFeiYong");
            dtTitle.Columns.Add("YingYeLiRun");
            dtTitle.Columns.Add("ZiChanJianZhiSunShi");
            dtTitle.Columns.Add("GongYunJiaZhiBianDongShouYi");
            dtTitle.Columns.Add("TouZiShouYi");
            dtTitle.Columns.Add("YingYeWaiShouZhiJingE");
            dtTitle.Columns.Add("LiRunZongE");
            dtTitle.Columns.Add("SuoDeShui");
            dtTitle.Columns.Add("ShueiHouLiRun");
            dtTitle.Columns.Add("ShaoShuGuDongSunYi");
            dtTitle.Columns.Add("JingLiRun");

            return dtTitle;
        }

        /// <summary>
        /// 上报损益预算
        /// </summary>
        /// <param name="PMID">主表ID</param>
        /// <returns></returns>
        public ActionResult ReportProfitLoss(int PMID)
        {
            ProfitLoss_MainModel PMainModel = new ProfitLoss_MainModel();
            PMainModel.UpdateReport(true, PMID);
            return RedirectToAction("Index", "ProfitLoss");
        }

        //预算表
        public ActionResult Detail(int YearID)
        {
            ViewBag.YearID = YearID;
            ProfitLoss_DetailedModel PDetailModel = new ProfitLoss_DetailedModel();
            var list = PDetailModel.GetDetailed_ByCompanyID(LoginAccount.ID, YearID);
            ViewBag.List = list;
            return View();
        }

        //保存预算表 
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Detail(string json, int YearID)
        {
            var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProfitLoss_Detailed>>(json);
            ProfitLoss_MainModel PMainModel = new ProfitLoss_MainModel();
            var LSpmain = PMainModel.GetMainInfo_ByCid_YID(LoginAccount.ID, YearID);
            ProfitLoss_Main Pmain = new ProfitLoss_Main();
            ProfitLoss_DetailedModel PDetailModel = new ProfitLoss_DetailedModel();
            if (LSpmain != null)
            {
                Pmain = LSpmain;
                //删除数据
                PDetailModel.DelInfo_ByMainID(Pmain.ID);
            }
            else
            {
                Pmain.CompanyID = LoginAccount.ID;
                Pmain.IsReport = false;
                Pmain.ParticularYearID = YearID;
                PMainModel.Add(Pmain);
            }
            foreach (var item in list)
            {
                item.ProfitLoss_MainID = Pmain.ID;
                item.CompanyID = LoginAccount.ID;
                PDetailModel.Add(item);
            }

            return RedirectToAction("Detail", "ProfitLoss"); ;
        }
    }
}
