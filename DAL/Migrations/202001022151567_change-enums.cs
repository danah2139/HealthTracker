namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeenums : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "_gender", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "_mood", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "_familyStatus", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "_activity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "_activity");
            DropColumn("dbo.Users", "_familyStatus");
            DropColumn("dbo.Users", "_mood");
            DropColumn("dbo.Users", "_gender");
        }
    }
}
