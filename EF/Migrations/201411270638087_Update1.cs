namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BudgetClass",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GroupID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Group", t => t.GroupID)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.CompanyAccount",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyID = c.Int(nullable: false),
                        AccountNumber = c.String(nullable: false, maxLength: 50),
                        AccountPwd = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Company", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.ProfitLoss_Coefficient",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyID = c.Int(nullable: false),
                        FenQiShuLiang = c.Double(nullable: false),
                        XinBaoShuLiang = c.Double(nullable: false),
                        XuBaoShuLiang = c.Double(nullable: false),
                        GuaPaiShuLiang = c.Double(nullable: false),
                        ErShouCheXiaoShouShuLiang = c.Double(nullable: false),
                        ZhuYingShouRu_ZhengChe = c.Double(nullable: false),
                        ZhuYingShouRu_ZhuangShiZhuangHuang = c.Double(nullable: false),
                        ZhuYingShouRu_FenQi = c.Double(nullable: false),
                        ZhuYingShouRu_XinBao = c.Double(nullable: false),
                        ZhuYingShouRu_XuBao = c.Double(nullable: false),
                        ZhuYingShouRu_GuaPai = c.Double(nullable: false),
                        ZhuYingShouRu_ErShouChe = c.Double(nullable: false),
                        ZhuYingChengBen_ZhengChe = c.Double(nullable: false),
                        ZhuYingChengBen_WeiXiuPeiJian = c.Double(nullable: false),
                        ZhuYingChengBen_ZhuangShiZhuangHuang = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Company", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.Group",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GroupAccount",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GroupID = c.Int(nullable: false),
                        AccountNumber = c.String(nullable: false, maxLength: 50),
                        AccountPwd = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Group", t => t.GroupID)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.ProfitLoss_Main",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyID = c.Int(nullable: false),
                        ParticularYearID = c.Int(nullable: false),
                        IsReport = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Company", t => t.CompanyID)
                .ForeignKey("dbo.ParticularYear", t => t.ParticularYearID)
                .Index(t => t.CompanyID)
                .Index(t => t.ParticularYearID);
            
            CreateTable(
                "dbo.ParticularYear",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProfitLoss_Detailed",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProfitLoss_MainID = c.Int(nullable: false),
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
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProfitLoss_Main", t => t.ProfitLoss_MainID)
                .Index(t => t.ProfitLoss_MainID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfitLoss_Detailed", "ProfitLoss_MainID", "dbo.ProfitLoss_Main");
            DropForeignKey("dbo.ProfitLoss_Main", "ParticularYearID", "dbo.ParticularYear");
            DropForeignKey("dbo.ProfitLoss_Main", "CompanyID", "dbo.Company");
            DropForeignKey("dbo.GroupAccount", "GroupID", "dbo.Group");
            DropForeignKey("dbo.Company", "GroupID", "dbo.Group");
            DropForeignKey("dbo.ProfitLoss_Coefficient", "CompanyID", "dbo.Company");
            DropForeignKey("dbo.CompanyAccount", "CompanyID", "dbo.Company");
            DropIndex("dbo.ProfitLoss_Detailed", new[] { "ProfitLoss_MainID" });
            DropIndex("dbo.ProfitLoss_Main", new[] { "ParticularYearID" });
            DropIndex("dbo.ProfitLoss_Main", new[] { "CompanyID" });
            DropIndex("dbo.GroupAccount", new[] { "GroupID" });
            DropIndex("dbo.ProfitLoss_Coefficient", new[] { "CompanyID" });
            DropIndex("dbo.CompanyAccount", new[] { "CompanyID" });
            DropIndex("dbo.Company", new[] { "GroupID" });
            DropTable("dbo.ProfitLoss_Detailed");
            DropTable("dbo.ParticularYear");
            DropTable("dbo.ProfitLoss_Main");
            DropTable("dbo.GroupAccount");
            DropTable("dbo.Group");
            DropTable("dbo.ProfitLoss_Coefficient");
            DropTable("dbo.CompanyAccount");
            DropTable("dbo.Company");
            DropTable("dbo.BudgetClass");
        }
    }
}
