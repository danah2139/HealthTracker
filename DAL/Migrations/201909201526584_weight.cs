namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class weight : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WeekComleteWeightInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        WeightNow = c.Double(nullable: false),
                        CurrentDate = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            DropColumn("dbo.Users", "Mood");
            DropColumn("dbo.Users", "FamilyStatus");
            DropColumn("dbo.Users", "Activity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Activity", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "FamilyStatus", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Mood", c => c.Int(nullable: false));
            DropForeignKey("dbo.WeekComleteWeightInfoes", "User_Id", "dbo.Users");
            DropIndex("dbo.WeekComleteWeightInfoes", new[] { "User_Id" });
            DropTable("dbo.WeekComleteWeightInfoes");
        }
    }
}
