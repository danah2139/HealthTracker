namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Nutrients", "Food_name", "dbo.Foods");
            DropForeignKey("dbo.RootObjects", "food_name", "dbo.Foods");
            DropForeignKey("dbo.Foods", "Report_sr", "dbo.Reports");
            DropForeignKey("dbo.RootObjects", "report_sr", "dbo.Reports");
            DropIndex("dbo.RootObjects", new[] { "food_name" });
            DropIndex("dbo.RootObjects", new[] { "report_sr" });
            DropIndex("dbo.Foods", new[] { "Report_sr" });
            DropIndex("dbo.Nutrients", new[] { "Food_name" });
            CreateTable(
                "dbo.Descs",
                c => new
                    {
                        ndbno = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        sd = c.String(),
                        fg = c.String(),
                        sn = c.String(),
                        cn = c.String(),
                        manu = c.String(),
                        nf = c.Double(nullable: false),
                        cf = c.Double(nullable: false),
                        ff = c.Double(nullable: false),
                        pf = c.Double(nullable: false),
                        r = c.String(),
                        rd = c.String(),
                        ds = c.String(),
                        ru = c.String(),
                    })
                .PrimaryKey(t => t.ndbno);
            
            DropTable("dbo.RootObjects");
            DropTable("dbo.Foods");
            DropTable("dbo.Nutrients");
            DropTable("dbo.Reports");
        }
        
        public override void Down()
        {
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
                "dbo.Nutrients",
                c => new
                    {
                        nutrient_id = c.String(nullable: false, maxLength: 128),
                        nutrient = c.String(),
                        unit = c.String(),
                        value = c.String(),
                        Food_name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.nutrient_id);
            
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
                .PrimaryKey(t => t.name);
            
            CreateTable(
                "dbo.RootObjects",
                c => new
                    {
                        key_id = c.String(nullable: false, maxLength: 128),
                        food_name = c.String(maxLength: 128),
                        report_sr = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.key_id);
            
            DropTable("dbo.Descs");
            CreateIndex("dbo.Nutrients", "Food_name");
            CreateIndex("dbo.Foods", "Report_sr");
            CreateIndex("dbo.RootObjects", "report_sr");
            CreateIndex("dbo.RootObjects", "food_name");
            AddForeignKey("dbo.RootObjects", "report_sr", "dbo.Reports", "sr");
            AddForeignKey("dbo.Foods", "Report_sr", "dbo.Reports", "sr");
            AddForeignKey("dbo.RootObjects", "food_name", "dbo.Foods", "name");
            AddForeignKey("dbo.Nutrients", "Food_name", "dbo.Foods", "name");
        }
    }
}
