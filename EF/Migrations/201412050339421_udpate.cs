namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class udpate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menu", "AccountType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menu", "AccountType");
        }
    }
}
