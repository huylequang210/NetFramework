namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BenhAns",
                c => new
                    {
                        BenhAnId = c.Int(nullable: false, identity: true),
                        Note = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Benh_BenhId = c.Int(),
                        BenhNhan_BenhNhanId = c.Int(),
                    })
                .PrimaryKey(t => t.BenhAnId)
                .ForeignKey("dbo.Benhs", t => t.Benh_BenhId)
                .ForeignKey("dbo.BenhNhans", t => t.BenhNhan_BenhNhanId)
                .Index(t => t.Benh_BenhId)
                .Index(t => t.BenhNhan_BenhNhanId);
            
            CreateTable(
                "dbo.Benhs",
                c => new
                    {
                        BenhId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        BenhNhan_BenhNhanId = c.Int(),
                    })
                .PrimaryKey(t => t.BenhId)
                .ForeignKey("dbo.BenhNhans", t => t.BenhNhan_BenhNhanId)
                .Index(t => t.BenhNhan_BenhNhanId);
            
            CreateTable(
                "dbo.BenhNhans",
                c => new
                    {
                        BenhNhanId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        HomeTown = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        InsuranceNumber = c.String(),
                        IDCard = c.String(),
                    })
                .PrimaryKey(t => t.BenhNhanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BenhAns", "BenhNhan_BenhNhanId", "dbo.BenhNhans");
            DropForeignKey("dbo.Benhs", "BenhNhan_BenhNhanId", "dbo.BenhNhans");
            DropForeignKey("dbo.BenhAns", "Benh_BenhId", "dbo.Benhs");
            DropIndex("dbo.Benhs", new[] { "BenhNhan_BenhNhanId" });
            DropIndex("dbo.BenhAns", new[] { "BenhNhan_BenhNhanId" });
            DropIndex("dbo.BenhAns", new[] { "Benh_BenhId" });
            DropTable("dbo.BenhNhans");
            DropTable("dbo.Benhs");
            DropTable("dbo.BenhAns");
        }
    }
}
