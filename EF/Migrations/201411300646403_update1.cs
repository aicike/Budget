namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProfitLoss_Detailed", "CompanyID", c => c.Int(nullable: false));
            CreateIndex("dbo.ProfitLoss_Detailed", "CompanyID");
            AddForeignKey("dbo.ProfitLoss_Detailed", "CompanyID", "dbo.Company", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfitLoss_Detailed", "CompanyID", "dbo.Company");
            DropIndex("dbo.ProfitLoss_Detailed", new[] { "CompanyID" });
            DropColumn("dbo.ProfitLoss_Detailed", "CompanyID");
        }
    }
}
