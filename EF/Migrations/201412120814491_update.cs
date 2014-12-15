namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expenses_Detail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyID = c.Int(nullable: false),
                        Expenses_MainlID = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        GongZi = c.Double(nullable: false),
                        Jiangjin = c.Double(nullable: false),
                        FuLiFei = c.Double(nullable: false),
                        YuanGongBaoXian = c.Double(nullable: false),
                        ZhiGongJiaoYuJingFei = c.Double(nullable: false),
                        GongHuiFeiYong = c.Double(nullable: false),
                        CiTuiFuLi = c.Double(nullable: false),
                        BanGongFei = c.Double(nullable: false),
                        TongXunFei = c.Double(nullable: false),
                        GuangXuanFei = c.Double(nullable: false),
                        PeiXunFei = c.Double(nullable: false),
                        ShuiDianNuanFei = c.Double(nullable: false),
                        ChaiLvFei = c.Double(nullable: false),
                        SuSongFei = c.Double(nullable: false),
                        CheLiangShiYongFei = c.Double(nullable: false),
                        YunShuFei = c.Double(nullable: false),
                        ShouHouShouQianFuWuFei = c.Double(nullable: false),
                        ShenJiFei = c.Double(nullable: false),
                        DiZhiYiHaoPin = c.Double(nullable: false),
                        WuLiaoXiaoHaoFei = c.Double(nullable: false),
                        YeWuZhaoDaiFei = c.Double(nullable: false),
                        LvHuaBaoJieFeiYong = c.Double(nullable: false),
                        BaoXianFei = c.Double(nullable: false),
                        XiuLiFei = c.Double(nullable: false),
                        ShuiJin = c.Double(nullable: false),
                        ZiXunFei_LaoWuFei = c.Double(nullable: false),
                        DongShiHuiFei = c.Double(nullable: false),
                        GongZhengFei = c.Double(nullable: false),
                        PaiWuFei = c.Double(nullable: false),
                        ChangJiaRuanJianShiYongFei = c.Double(nullable: false),
                        ZhaoBiaoShouXuFei = c.Double(nullable: false),
                        HuiYiFei = c.Double(nullable: false),
                        FuWuFei = c.Double(nullable: false),
                        QiTa = c.Double(nullable: false),
                        ZheJiuFei = c.Double(nullable: false),
                        WuXingZiChanTanFei = c.Double(nullable: false),
                        ChangQiDaiTanFeiYongTanXiao = c.Double(nullable: false),
                        ZuPingWuGuanFei = c.Double(nullable: false),
                        LiXiShouRu = c.Double(nullable: false),
                        LiXiZhiChu = c.Double(nullable: false),
                        ShouXuFei = c.Double(nullable: false),
                        DanBaoFei = c.Double(nullable: false),
                        QiTa_CaiWuFeiYong = c.Double(nullable: false),
                        Expenses_Main_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Company", t => t.CompanyID)
                .ForeignKey("dbo.Expenses_Main", t => t.Expenses_Main_ID)
                .Index(t => t.CompanyID)
                .Index(t => t.Expenses_Main_ID);
            
            CreateTable(
                "dbo.Expenses_Main",
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Expenses_Main", "ParticularYearID", "dbo.ParticularYear");
            DropForeignKey("dbo.Expenses_Detail", "Expenses_Main_ID", "dbo.Expenses_Main");
            DropForeignKey("dbo.Expenses_Main", "CompanyID", "dbo.Company");
            DropForeignKey("dbo.Expenses_Detail", "CompanyID", "dbo.Company");
            DropIndex("dbo.Expenses_Main", new[] { "ParticularYearID" });
            DropIndex("dbo.Expenses_Main", new[] { "CompanyID" });
            DropIndex("dbo.Expenses_Detail", new[] { "Expenses_Main_ID" });
            DropIndex("dbo.Expenses_Detail", new[] { "CompanyID" });
            DropTable("dbo.Expenses_Main");
            DropTable("dbo.Expenses_Detail");
        }
    }
}
