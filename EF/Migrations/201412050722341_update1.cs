namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menu", "IsShow", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menu", "IsShow");
        }
    }
}
