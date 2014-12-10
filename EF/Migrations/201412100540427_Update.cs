namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoleAccount",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleID = c.Int(nullable: false),
                        GroupAccountID = c.Int(),
                        CompanyAccountID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CompanyAccount", t => t.CompanyAccountID)
                .ForeignKey("dbo.GroupAccount", t => t.GroupAccountID)
                .ForeignKey("dbo.Role", t => t.RoleID)
                .Index(t => t.RoleID)
                .Index(t => t.GroupAccountID)
                .Index(t => t.CompanyAccountID);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AccountType = c.Int(nullable: false),
                        RoleName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RoleMenu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MenuID = c.Int(nullable: false),
                        RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Menu", t => t.MenuID)
                .ForeignKey("dbo.Role", t => t.RoleID)
                .Index(t => t.MenuID)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.MenuOption",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MenuID = c.Int(nullable: false),
                        Name = c.String(),
                        Controller = c.String(),
                        Action = c.String(),
                        Order = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Menu", t => t.MenuID)
                .Index(t => t.MenuID);
            
            CreateTable(
                "dbo.RoleOption",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleID = c.Int(nullable: false),
                        MenuOptionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MenuOption", t => t.MenuOptionID)
                .ForeignKey("dbo.Role", t => t.RoleID)
                .Index(t => t.RoleID)
                .Index(t => t.MenuOptionID);
            
            AddColumn("dbo.ProfitLossReality_Detail", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Menu", "AccountType", c => c.Int(nullable: false));
            AddColumn("dbo.Menu", "IsShow", c => c.Boolean());
            AlterColumn("dbo.CompanyAccount", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.GroupAccount", "Email", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.ProfitLossReality_Main", "IsReport");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProfitLossReality_Main", "IsReport", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.RoleMenu", "RoleID", "dbo.Role");
            DropForeignKey("dbo.RoleMenu", "MenuID", "dbo.Menu");
            DropForeignKey("dbo.RoleOption", "RoleID", "dbo.Role");
            DropForeignKey("dbo.RoleOption", "MenuOptionID", "dbo.MenuOption");
            DropForeignKey("dbo.MenuOption", "MenuID", "dbo.Menu");
            DropForeignKey("dbo.RoleAccount", "RoleID", "dbo.Role");
            DropForeignKey("dbo.RoleAccount", "GroupAccountID", "dbo.GroupAccount");
            DropForeignKey("dbo.RoleAccount", "CompanyAccountID", "dbo.CompanyAccount");
            DropIndex("dbo.RoleOption", new[] { "MenuOptionID" });
            DropIndex("dbo.RoleOption", new[] { "RoleID" });
            DropIndex("dbo.MenuOption", new[] { "MenuID" });
            DropIndex("dbo.RoleMenu", new[] { "RoleID" });
            DropIndex("dbo.RoleMenu", new[] { "MenuID" });
            DropIndex("dbo.RoleAccount", new[] { "CompanyAccountID" });
            DropIndex("dbo.RoleAccount", new[] { "GroupAccountID" });
            DropIndex("dbo.RoleAccount", new[] { "RoleID" });
            AlterColumn("dbo.GroupAccount", "Email", c => c.String());
            AlterColumn("dbo.CompanyAccount", "Email", c => c.String());
            DropColumn("dbo.Menu", "IsShow");
            DropColumn("dbo.Menu", "AccountType");
            DropColumn("dbo.ProfitLossReality_Detail", "Status");
            DropTable("dbo.RoleOption");
            DropTable("dbo.MenuOption");
            DropTable("dbo.RoleMenu");
            DropTable("dbo.Role");
            DropTable("dbo.RoleAccount");
        }
    }
}
