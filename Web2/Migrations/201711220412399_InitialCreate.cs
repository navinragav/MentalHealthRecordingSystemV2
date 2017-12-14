namespace Web2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consultants",
                c => new
                    {
                        cid = c.Int(nullable: false, identity: true),
                        cname = c.String(nullable: false, maxLength: 20),
                        psychologist = c.Int(nullable: false),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.cid);
            
            CreateTable(
                "dbo.Nurses",
                c => new
                    {
                        nid = c.Int(nullable: false, identity: true),
                        nname = c.String(nullable: false, maxLength: 20),
                        grade = c.Int(nullable: false),
                        Phone = c.String(),
                        cid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.nid)
                .ForeignKey("dbo.Consultants", t => t.cid, cascadeDelete: true)
                .Index(t => t.cid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Nurses", "cid", "dbo.Consultants");
            DropIndex("dbo.Nurses", new[] { "cid" });
            DropTable("dbo.Nurses");
            DropTable("dbo.Consultants");
        }
    }
}
