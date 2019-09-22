namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Mood", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "FamilyStatus", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Activity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Activity");
            DropColumn("dbo.Users", "FamilyStatus");
            DropColumn("dbo.Users", "Mood");
        }
    }
}
