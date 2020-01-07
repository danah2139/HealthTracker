namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Gender");
            DropColumn("dbo.Users", "Mood");
            DropColumn("dbo.Users", "FamilyStatus");
            DropColumn("dbo.Users", "Activity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Activity", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "FamilyStatus", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Mood", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Gender", c => c.Int(nullable: false));
        }
    }
}
