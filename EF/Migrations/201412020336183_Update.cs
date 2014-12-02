namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProfitLossReality_Main",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        CompanyID = c.Int(nullable: false),
                        ProfitLoss_DetailedID = c.Int(nullable: false),
                        ParticularYearID = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        XiaoShouShuLiang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        XinCheXiaoShouShuLiang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WeiXiuJinChangTaiCi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FenQiShuLiang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        XinBaoShuLiang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        XuBaoShuLiang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        YanBaoShuLiang = c.Decimal(precision: 18, scale: 2),
                        GuaPaiShuLiang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ErShouCheXiaoShouShuLiang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingYeWuShouRu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_ZhengChe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_ShouHouWeiXiu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_WeiXiuPeiJian = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_GongShi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_ZhuangShiZhuangHuang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_YongJin = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_FenQi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_BaoXian = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_XinBao = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_XuBao = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_YanBao = c.Decimal(precision: 18, scale: 2),
                        ZhuYingShouRu_GuaPai = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_ErShouChe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_QiTa = c.Decimal(precision: 18, scale: 2),
                        ZhuYingYeWuChengBen = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingChengBen_ZhengChe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingChengBen_ShouHouWeiXiu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingChengBen_WeiXiuPeiJian = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingChengBen_GongShi = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_ZhuangShiZhuangHuang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingChengBen_YongJin = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_FenQi = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_BaoXian = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_XinBao = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_XuBao = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_YanBao = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_GuaPai = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_ErShouChe = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_QiTa = c.Decimal(precision: 18, scale: 2),
                        MaoLi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaoLi_ZhengChe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaoLi_WeiXiu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaoLi_ZhuangShiZhuangHuang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaoLi_YongJin = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingYeWuShueiJinJiFuJia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingYeWuFuJiaShuiHouMaoLi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QiTaYeWuShouRu = c.Decimal(precision: 18, scale: 2),
                        QiTaYeWuChengBen = c.Decimal(precision: 18, scale: 2),
                        QiTaYeWuShuiJinJiFuJia = c.Decimal(precision: 18, scale: 2),
                        QiTaYeWuLiRun = c.Decimal(precision: 18, scale: 2),
                        XiaoShouJiGuanLiFeiYong = c.Decimal(nullable: false, precision: 18, scale: 2),
                        XiShueiQianLiRun = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CaiWuFeiYong = c.Decimal(nullable: false, precision: 18, scale: 2),
                        YingYeLiRun = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZiChanJianZhiSunShi = c.Decimal(precision: 18, scale: 2),
                        GongYunJiaZhiBianDongShouYi = c.Decimal(precision: 18, scale: 2),
                        TouZiShouYi = c.Decimal(precision: 18, scale: 2),
                        YingYeWaiShouZhiJingE = c.Decimal(precision: 18, scale: 2),
                        LiRunZongE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SuoDeShui = c.Decimal(precision: 18, scale: 2),
                        ShueiHouLiRun = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ShaoShuGuDongSunYi = c.Decimal(precision: 18, scale: 2),
                        JingLiRun = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Company", t => t.CompanyID)
                .ForeignKey("dbo.ParticularYear", t => t.ParticularYearID)
                .ForeignKey("dbo.ProfitLoss_Detailed", t => t.ID)
                .Index(t => t.ID)
                .Index(t => t.CompanyID)
                .Index(t => t.ParticularYearID);
            
            CreateTable(
                "dbo.ProfitLossReality_Detail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProfitLossReality_MainID = c.Int(nullable: false),
                        Week = c.Int(nullable: false),
                        XiaoShouShuLiang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        XinCheXiaoShouShuLiang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WeiXiuJinChangTaiCi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FenQiShuLiang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        XinBaoShuLiang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        XuBaoShuLiang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        YanBaoShuLiang = c.Decimal(precision: 18, scale: 2),
                        GuaPaiShuLiang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ErShouCheXiaoShouShuLiang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingYeWuShouRu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_ZhengChe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_ShouHouWeiXiu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_WeiXiuPeiJian = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_GongShi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_ZhuangShiZhuangHuang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_YongJin = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_FenQi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_BaoXian = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_XinBao = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_XuBao = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_YanBao = c.Decimal(precision: 18, scale: 2),
                        ZhuYingShouRu_GuaPai = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_ErShouChe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingShouRu_QiTa = c.Decimal(precision: 18, scale: 2),
                        ZhuYingYeWuChengBen = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingChengBen_ZhengChe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingChengBen_ShouHouWeiXiu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingChengBen_WeiXiuPeiJian = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingChengBen_GongShi = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_ZhuangShiZhuangHuang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingChengBen_YongJin = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_FenQi = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_BaoXian = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_XinBao = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_XuBao = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_YanBao = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_GuaPai = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_ErShouChe = c.Decimal(precision: 18, scale: 2),
                        ZhuYingChengBen_QiTa = c.Decimal(precision: 18, scale: 2),
                        MaoLi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaoLi_ZhengChe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaoLi_WeiXiu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaoLi_ZhuangShiZhuangHuang = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaoLi_YongJin = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingYeWuShueiJinJiFuJia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZhuYingYeWuFuJiaShuiHouMaoLi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QiTaYeWuShouRu = c.Decimal(precision: 18, scale: 2),
                        QiTaYeWuChengBen = c.Decimal(precision: 18, scale: 2),
                        QiTaYeWuShuiJinJiFuJia = c.Decimal(precision: 18, scale: 2),
                        QiTaYeWuLiRun = c.Decimal(precision: 18, scale: 2),
                        XiaoShouJiGuanLiFeiYong = c.Decimal(nullable: false, precision: 18, scale: 2),
                        XiShueiQianLiRun = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CaiWuFeiYong = c.Decimal(nullable: false, precision: 18, scale: 2),
                        YingYeLiRun = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZiChanJianZhiSunShi = c.Decimal(precision: 18, scale: 2),
                        GongYunJiaZhiBianDongShouYi = c.Decimal(precision: 18, scale: 2),
                        TouZiShouYi = c.Decimal(precision: 18, scale: 2),
                        YingYeWaiShouZhiJingE = c.Decimal(precision: 18, scale: 2),
                        LiRunZongE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SuoDeShui = c.Decimal(precision: 18, scale: 2),
                        ShueiHouLiRun = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ShaoShuGuDongSunYi = c.Decimal(precision: 18, scale: 2),
                        JingLiRun = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProfitLossReality_Main", t => t.ProfitLossReality_MainID)
                .Index(t => t.ProfitLossReality_MainID);
            
            AddColumn("dbo.ProfitLoss_Detailed", "ProfitLossReality_MainID", c => c.Int());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfitLossReality_Detail", "ProfitLossReality_MainID", "dbo.ProfitLossReality_Main");
            DropForeignKey("dbo.ProfitLossReality_Main", "ID", "dbo.ProfitLoss_Detailed");
            DropForeignKey("dbo.ProfitLossReality_Main", "ParticularYearID", "dbo.ParticularYear");
            DropForeignKey("dbo.ProfitLossReality_Main", "CompanyID", "dbo.Company");
            DropIndex("dbo.ProfitLossReality_Detail", new[] { "ProfitLossReality_MainID" });
            DropIndex("dbo.ProfitLossReality_Main", new[] { "ParticularYearID" });
            DropIndex("dbo.ProfitLossReality_Main", new[] { "CompanyID" });
            DropIndex("dbo.ProfitLossReality_Main", new[] { "ID" });
            DropColumn("dbo.ProfitLoss_Detailed", "ProfitLossReality_MainID");
            DropTable("dbo.ProfitLossReality_Detail");
            DropTable("dbo.ProfitLossReality_Main");
        }
    }
}
