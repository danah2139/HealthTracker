namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "DateOfWeight", c => c.String());
            AlterColumn("dbo.Users", "Weight", c => c.Double(nullable: false));
            DropTable("dbo.Descs");
        }
        
        public override void Down()
        {
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
            
            AlterColumn("dbo.Users", "Weight", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "DateOfWeight");
        }
    }
}
