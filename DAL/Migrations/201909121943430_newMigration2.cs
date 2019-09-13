namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Users", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Users", "Name");
        }
    }
}
