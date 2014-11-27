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


            var migrationDir = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\");
            var ddlSqlFiles = new string[] { "Initial.sql" };
            foreach (var file in ddlSqlFiles)
            {
                string scriptText = System.IO.File.ReadAllText(System.IO.Path.Combine(migrationDir, file));
                var commandTexts = scriptText.Split(new string[] { "\r\nGO\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var commandText in commandTexts)
                {
                    if (!String.IsNullOrWhiteSpace(commandText))
                        Sql(commandText);
                }
            }
        }

        public override void Down()
        {
            DropForeignKey("dbo.Menu", "ParentMenuID", "dbo.Menu");
            DropIndex("dbo.Menu", new[] { "ParentMenuID" });
            DropTable("dbo.Menu");
        }
    }
}
