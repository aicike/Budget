namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Area = c.String(),
                        Controller = c.String(),
                        Action = c.String(),
                        Name = c.String(nullable: false, maxLength: 20),
                        ShowName = c.String(nullable: false, maxLength: 20),
                        Order = c.Int(nullable: false),
                        ParentMenuID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Menu", t => t.ParentMenuID)
                .Index(t => t.ParentMenuID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Menu", "ParentMenuID", "dbo.Menu");
            DropIndex("dbo.Menu", new[] { "ParentMenuID" });
            DropTable("dbo.Menu");
        }
    }
}
