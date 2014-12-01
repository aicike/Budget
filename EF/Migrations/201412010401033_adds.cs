namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adds : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProfitLoss_Detailed", "XiaoShouShuLiang", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "XinCheXiaoShouShuLiang", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "WeiXiuJinChangTaiCi", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "FenQiShuLiang", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "XinBaoShuLiang", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "XuBaoShuLiang", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "YanBaoShuLiang", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "GuaPaiShuLiang", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ErShouCheXiaoShouShuLiang", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingYeWuShouRu", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_ZhengChe", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_ShouHouWeiXiu", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_WeiXiuPeiJian", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_GongShi", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_ZhuangShiZhuangHuang", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_YongJin", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_FenQi", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_BaoXian", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_XinBao", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_XuBao", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_YanBao", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_GuaPai", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_ErShouChe", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_QiTa", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingYeWuChengBen", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_ZhengChe", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_ShouHouWeiXiu", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_WeiXiuPeiJian", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_GongShi", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_ZhuangShiZhuangHuang", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_YongJin", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_FenQi", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_BaoXian", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_XinBao", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_XuBao", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_YanBao", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_GuaPai", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_ErShouChe", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_QiTa", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "MaoLi", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "MaoLi_ZhengChe", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "MaoLi_WeiXiu", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "MaoLi_ZhuangShiZhuangHuang", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "MaoLi_YongJin", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingYeWuShueiJinJiFuJia", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingYeWuFuJiaShuiHouMaoLi", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuShouRu", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuChengBen", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuShuiJinJiFuJia", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuLiRun", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "XiaoShouJiGuanLiFeiYong", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "XiShueiQianLiRun", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "CaiWuFeiYong", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "YingYeLiRun", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZiChanJianZhiSunShi", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "GongYunJiaZhiBianDongShouYi", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "TouZiShouYi", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "YingYeWaiShouZhiJingE", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "LiRunZongE", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "SuoDeShui", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "ShueiHouLiRun", c => c.Double(nullable: false));
            AlterColumn("dbo.ProfitLoss_Detailed", "ShaoShuGuDongSunYi", c => c.Double());
            AlterColumn("dbo.ProfitLoss_Detailed", "JingLiRun", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProfitLoss_Detailed", "JingLiRun", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ShaoShuGuDongSunYi", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ShueiHouLiRun", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "SuoDeShui", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "LiRunZongE", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "YingYeWaiShouZhiJingE", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "TouZiShouYi", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "GongYunJiaZhiBianDongShouYi", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZiChanJianZhiSunShi", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "YingYeLiRun", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "CaiWuFeiYong", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "XiShueiQianLiRun", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "XiaoShouJiGuanLiFeiYong", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuLiRun", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuShuiJinJiFuJia", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuChengBen", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuShouRu", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingYeWuFuJiaShuiHouMaoLi", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingYeWuShueiJinJiFuJia", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "MaoLi_YongJin", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "MaoLi_ZhuangShiZhuangHuang", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "MaoLi_WeiXiu", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "MaoLi_ZhengChe", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "MaoLi", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_QiTa", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_ErShouChe", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_GuaPai", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_YanBao", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_XuBao", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_XinBao", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_BaoXian", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_FenQi", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_YongJin", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_ZhuangShiZhuangHuang", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_GongShi", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_WeiXiuPeiJian", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_ShouHouWeiXiu", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingChengBen_ZhengChe", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingYeWuChengBen", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_QiTa", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_ErShouChe", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_GuaPai", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_YanBao", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_XuBao", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_XinBao", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_BaoXian", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_FenQi", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_YongJin", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_ZhuangShiZhuangHuang", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_GongShi", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_WeiXiuPeiJian", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_ShouHouWeiXiu", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingShouRu_ZhengChe", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ZhuYingYeWuShouRu", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "ErShouCheXiaoShouShuLiang", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "GuaPaiShuLiang", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "YanBaoShuLiang", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "XuBaoShuLiang", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "XinBaoShuLiang", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "FenQiShuLiang", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "WeiXiuJinChangTaiCi", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "XinCheXiaoShouShuLiang", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProfitLoss_Detailed", "XiaoShouShuLiang", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
