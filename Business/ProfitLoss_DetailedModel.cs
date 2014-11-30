using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Data;

namespace Business
{
    /// <summary>
    /// 损益预算 明细表 MODEL
    /// </summary>
    public class ProfitLoss_DetailedModel : BaseModel<ProfitLoss_Detailed>
    {

        /// <summary>
        /// 根据公司ID 与年份 获取损益预算
        /// </summary>
        /// <param name="CID">公司ID</param>
        /// <param name="YearID">年份ID</param>
        /// <returns></returns>
        public List<ProfitLoss_Detailed> GetDetailed_ByCompanyID(int CID, int YearID)
        {
            var list = List().Where(a => a.CompanyID == CID && a.ProfitLoss_Main.ParticularYearID == YearID).OrderBy(a=>a.Month).ToList();
            return list;
        }

        /// <summary>
        /// 根据主表IDS 获取明细汇总数据
        /// </summary>
        /// <param name="MainIDs"></param>
        /// <returns></returns>
        public DataTable GetStatistics_ByMainID(string MainIDs)
        {
            string sql = @"select CompanyID,(select Name from Company a where a.ID = CompanyID) as CompanyName,
                            sum(XiaoShouShuLiang) as XiaoShouShuLiang,
                            sum(XinCheXiaoShouShuLiang) as XinCheXiaoShouShuLiang,
                            sum(WeiXiuJinChangTaiCi) as WeiXiuJinChangTaiCi,
                            sum(FenQiShuLiang) as FenQiShuLiang,
                            sum(XinBaoShuLiang) as XinBaoShuLiang,
                            sum(XuBaoShuLiang) as XuBaoShuLiang,
                            sum(YanBaoShuLiang) as YanBaoShuLiang,
                            sum(GuaPaiShuLiang) as GuaPaiShuLiang,
                            sum(ErShouCheXiaoShouShuLiang) as ErShouCheXiaoShouShuLiang,
                            sum(ZhuYingYeWuShouRu) as ZhuYingYeWuShouRu,
                            sum(ZhuYingShouRu_ZhengChe) as ZhuYingShouRu_ZhengChe,
                            sum(ZhuYingShouRu_ShouHouWeiXiu) as ZhuYingShouRu_ShouHouWeiXiu,
                            sum(ZhuYingShouRu_WeiXiuPeiJian) as ZhuYingShouRu_WeiXiuPeiJian,
                            sum(ZhuYingShouRu_GongShi) as ZhuYingShouRu_GongShi,
                            sum(ZhuYingShouRu_ZhuangShiZhuangHuang) as ZhuYingShouRu_ZhuangShiZhuangHuang,
                            sum(ZhuYingShouRu_YongJin) as ZhuYingShouRu_YongJin,
                            sum(ZhuYingShouRu_FenQi) as ZhuYingShouRu_FenQi,
                            sum(ZhuYingShouRu_BaoXian) as ZhuYingShouRu_BaoXian,
                            sum(ZhuYingShouRu_XinBao) as ZhuYingShouRu_XinBao,
                            sum(ZhuYingShouRu_XuBao) as ZhuYingShouRu_XuBao,
                            sum(ZhuYingShouRu_YanBao) as ZhuYingShouRu_YanBao,
                            sum(ZhuYingShouRu_GuaPai) as ZhuYingShouRu_GuaPai,
                            sum(ZhuYingShouRu_ErShouChe) as ZhuYingShouRu_ErShouChe,
                            sum(ZhuYingShouRu_QiTa) as ZhuYingShouRu_QiTa,
                            sum(ZhuYingYeWuChengBen) as ZhuYingYeWuChengBen,
                            sum(ZhuYingChengBen_ZhengChe) as ZhuYingChengBen_ZhengChe,
                            sum(ZhuYingChengBen_ShouHouWeiXiu) as ZhuYingChengBen_ShouHouWeiXiu,
                            sum(ZhuYingChengBen_WeiXiuPeiJian) as ZhuYingChengBen_WeiXiuPeiJian,
                            sum(ZhuYingChengBen_GongShi) as ZhuYingChengBen_GongShi,
                            sum(ZhuYingChengBen_ZhuangShiZhuangHuang) as ZhuYingChengBen_ZhuangShiZhuangHuang,
                            sum(ZhuYingChengBen_YongJin) as ZhuYingChengBen_YongJin,
                            sum(ZhuYingChengBen_FenQi) as ZhuYingChengBen_FenQi,
                            sum(ZhuYingChengBen_BaoXian) as ZhuYingChengBen_BaoXian,
                            sum(ZhuYingChengBen_XinBao) as ZhuYingChengBen_XinBao,
                            sum(ZhuYingChengBen_XuBao) as ZhuYingChengBen_XuBao,
                            sum(ZhuYingChengBen_YanBao) as ZhuYingChengBen_YanBao,
                            sum(ZhuYingChengBen_GuaPai) as ZhuYingChengBen_GuaPai,
                            sum(ZhuYingChengBen_ErShouChe) as ZhuYingChengBen_ErShouChe,
                            sum(ZhuYingChengBen_QiTa) as ZhuYingChengBen_QiTa,
                            sum(MaoLi) as MaoLi,
                            sum(MaoLi_ZhengChe) as MaoLi_ZhengChe,
                            sum(MaoLi_WeiXiu) as MaoLi_WeiXiu,
                            sum(MaoLi_ZhuangShiZhuangHuang) as MaoLi_ZhuangShiZhuangHuang,
                            sum(MaoLi_YongJin) as MaoLi_YongJin,
                            sum(ZhuYingYeWuShueiJinJiFuJia) as ZhuYingYeWuShueiJinJiFuJia,
                            sum(ZhuYingYeWuFuJiaShuiHouMaoLi) as ZhuYingYeWuFuJiaShuiHouMaoLi,
                            sum(QiTaYeWuShouRu) as QiTaYeWuShouRu,
                            sum(QiTaYeWuChengBen) as QiTaYeWuChengBen,
                            sum(QiTaYeWuShuiJinJiFuJia) as QiTaYeWuShuiJinJiFuJia,
                            sum(QiTaYeWuLiRun) as QiTaYeWuLiRun,
                            sum(XiaoShouJiGuanLiFeiYong) as XiaoShouJiGuanLiFeiYong,
                            sum(XiShueiQianLiRun) as XiShueiQianLiRun,
                            sum(CaiWuFeiYong) as CaiWuFeiYong,
                            sum(YingYeLiRun) as YingYeLiRun,
                            sum(ZiChanJianZhiSunShi) as ZiChanJianZhiSunShi,
                            sum(GongYunJiaZhiBianDongShouYi) as GongYunJiaZhiBianDongShouYi,
                            sum(TouZiShouYi) as TouZiShouYi,
                            sum(YingYeWaiShouZhiJingE) as YingYeWaiShouZhiJingE,
                            sum(LiRunZongE) as LiRunZongE,
                            sum(SuoDeShui) as SuoDeShui,
                            sum(ShueiHouLiRun) as ShueiHouLiRun,
                            sum(ShaoShuGuDongSunYi) as ShaoShuGuDongSunYi,
                            sum(JingLiRun) as JingLiRun
                             from dbo.ProfitLoss_Detailed where Profitloss_MainID in ("+MainIDs+") group by CompanyID";

            var data = SqlHelper.ExecuteDataset(sql);
            return data.Tables[0];
        }


        /// <summary>
        /// 删除明细数据
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public Result DelInfo_ByMainID(int MainID)
        {
            Result result = new Result();
            string sql = "delete ProfitLoss_Detailed where ProfitLoss_MainID = "+MainID;
            base.SqlExecute(sql);
            return result;
        }


    }
}
