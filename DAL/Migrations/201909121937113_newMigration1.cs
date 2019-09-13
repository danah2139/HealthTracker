namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Users", "Name");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Users", "Name");
        }
    }
}
