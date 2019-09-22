namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bka : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserId = c.String(),
                        GoalWeight = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Weight = c.Double(nullable: false),
                        DateOfWeight = c.String(),
                        Gender = c.Int(nullable: false),
                        Mood = c.Int(nullable: false),
                        FamilyStatus = c.Int(nullable: false),
                        Activity = c.Int(nullable: false),
                        DateOfBirth = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
