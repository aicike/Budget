namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RoleAccount", "RoleID", "dbo.Role");
            DropForeignKey("dbo.RoleMenu", "RoleID", "dbo.Role");
            DropForeignKey("dbo.RoleOption", "RoleID", "dbo.Role");
            AddForeignKey("dbo.RoleAccount", "RoleID", "dbo.Role", "ID", cascadeDelete: true);
            AddForeignKey("dbo.RoleMenu", "RoleID", "dbo.Role", "ID", cascadeDelete: true);
            AddForeignKey("dbo.RoleOption", "RoleID", "dbo.Role", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoleOption", "RoleID", "dbo.Role");
            DropForeignKey("dbo.RoleMenu", "RoleID", "dbo.Role");
            DropForeignKey("dbo.RoleAccount", "RoleID", "dbo.Role");
            AddForeignKey("dbo.RoleOption", "RoleID", "dbo.Role", "ID");
            AddForeignKey("dbo.RoleMenu", "RoleID", "dbo.Role", "ID");
            AddForeignKey("dbo.RoleAccount", "RoleID", "dbo.Role", "ID");
        }
    }
}
