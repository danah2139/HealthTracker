namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RootObjects",
                c => new
                    {
                        key_id = c.String(nullable: false, maxLength: 128),
                        food_name = c.String(maxLength: 128),
                        report_sr = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.key_id)
                .ForeignKey("dbo.Foods", t => t.food_name)
                .ForeignKey("dbo.Reports", t => t.report_sr)
                .Index(t => t.food_name)
                .Index(t => t.report_sr);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                        ndbno = c.String(),
                        weight = c.Double(nullable: false),
                        measure = c.String(),
                        Report_sr = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.name)
                .ForeignKey("dbo.Reports", t => t.Report_sr)
                .Index(t => t.Report_sr);
            
            CreateTable(
                "dbo.Nutrients",
                c => new
                    {
                        nutrient_id = c.String(nullable: false, maxLength: 128),
                        nutrient = c.String(),
                        unit = c.String(),
                        value = c.String(),
                        Food_name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.nutrient_id)
                .ForeignKey("dbo.Foods", t => t.Food_name)
                .Index(t => t.Food_name);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        sr = c.String(nullable: false, maxLength: 128),
                        groups = c.String(),
                        subset = c.String(),
                        end = c.Int(nullable: false),
                        start = c.Int(nullable: false),
                        total = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.sr);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GoalWeight = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RootObjects", "report_sr", "dbo.Reports");
            DropForeignKey("dbo.Foods", "Report_sr", "dbo.Reports");
            DropForeignKey("dbo.RootObjects", "food_name", "dbo.Foods");
            DropForeignKey("dbo.Nutrients", "Food_name", "dbo.Foods");
            DropIndex("dbo.Nutrients", new[] { "Food_name" });
            DropIndex("dbo.Foods", new[] { "Report_sr" });
            DropIndex("dbo.RootObjects", new[] { "report_sr" });
            DropIndex("dbo.RootObjects", new[] { "food_name" });
            DropTable("dbo.Users");
            DropTable("dbo.Reports");
            DropTable("dbo.Nutrients");
            DropTable("dbo.Foods");
            DropTable("dbo.RootObjects");
        }
    }
}
