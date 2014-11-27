namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProfitLoss_Detailed", "MaoLi", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "MaoLi_ZhengChe", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "MaoLi_WeiXiu", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "MaoLi_ZhuangShiZhuangHuang", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "MaoLi_YongJin", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "ZhuYingYeWuShueiJinJiFuJia", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "ZhuYingYeWuFuJiaShuiHouMaoLi", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuShouRu", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuChengBen", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuShuiJinJiFuJia", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuLiRun", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "XiaoShouJiGuanLiFeiYong", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "XiShueiQianLiRun", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "CaiWuFeiYong", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "YingYeLiRun", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "ZiChanJianZhiSunShi", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "GongYunJiaZhiBianDongShouYi", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "TouZiShouYi", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "YingYeWaiShouZhiJingE", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "LiRunZongE", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "SuoDeShui", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "ShueiHouLiRun", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "ShaoShuGuDongSunYi", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.ProfitLoss_Detailed", "JingLiRun", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProfitLoss_Detailed", "JingLiRun");
            DropColumn("dbo.ProfitLoss_Detailed", "ShaoShuGuDongSunYi");
            DropColumn("dbo.ProfitLoss_Detailed", "ShueiHouLiRun");
            DropColumn("dbo.ProfitLoss_Detailed", "SuoDeShui");
            DropColumn("dbo.ProfitLoss_Detailed", "LiRunZongE");
            DropColumn("dbo.ProfitLoss_Detailed", "YingYeWaiShouZhiJingE");
            DropColumn("dbo.ProfitLoss_Detailed", "TouZiShouYi");
            DropColumn("dbo.ProfitLoss_Detailed", "GongYunJiaZhiBianDongShouYi");
            DropColumn("dbo.ProfitLoss_Detailed", "ZiChanJianZhiSunShi");
            DropColumn("dbo.ProfitLoss_Detailed", "YingYeLiRun");
            DropColumn("dbo.ProfitLoss_Detailed", "CaiWuFeiYong");
            DropColumn("dbo.ProfitLoss_Detailed", "XiShueiQianLiRun");
            DropColumn("dbo.ProfitLoss_Detailed", "XiaoShouJiGuanLiFeiYong");
            DropColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuLiRun");
            DropColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuShuiJinJiFuJia");
            DropColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuChengBen");
            DropColumn("dbo.ProfitLoss_Detailed", "QiTaYeWuShouRu");
            DropColumn("dbo.ProfitLoss_Detailed", "ZhuYingYeWuFuJiaShuiHouMaoLi");
            DropColumn("dbo.ProfitLoss_Detailed", "ZhuYingYeWuShueiJinJiFuJia");
            DropColumn("dbo.ProfitLoss_Detailed", "MaoLi_YongJin");
            DropColumn("dbo.ProfitLoss_Detailed", "MaoLi_ZhuangShiZhuangHuang");
            DropColumn("dbo.ProfitLoss_Detailed", "MaoLi_WeiXiu");
            DropColumn("dbo.ProfitLoss_Detailed", "MaoLi_ZhengChe");
            DropColumn("dbo.ProfitLoss_Detailed", "MaoLi");
        }
    }
}
