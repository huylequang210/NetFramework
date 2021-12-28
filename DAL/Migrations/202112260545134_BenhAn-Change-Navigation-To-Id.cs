namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BenhAnChangeNavigationToId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BenhAns", "Benh_BenhId", "dbo.Benhs");
            DropForeignKey("dbo.BenhAns", "BenhNhan_BenhNhanId", "dbo.BenhNhans");
            DropIndex("dbo.BenhAns", new[] { "Benh_BenhId" });
            DropIndex("dbo.BenhAns", new[] { "BenhNhan_BenhNhanId" });
            RenameColumn(table: "dbo.BenhAns", name: "BenhNhan_BenhNhanId", newName: "BenhNhanId");
            AddColumn("dbo.BenhAns", "BenhId", c => c.Int(nullable: false));
            AlterColumn("dbo.BenhAns", "BenhNhanId", c => c.Int(nullable: false));
            CreateIndex("dbo.BenhAns", "BenhNhanId");
            AddForeignKey("dbo.BenhAns", "BenhNhanId", "dbo.BenhNhans", "BenhNhanId", cascadeDelete: true);
            DropColumn("dbo.BenhAns", "Benh_BenhId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BenhAns", "Benh_BenhId", c => c.Int());
            DropForeignKey("dbo.BenhAns", "BenhNhanId", "dbo.BenhNhans");
            DropIndex("dbo.BenhAns", new[] { "BenhNhanId" });
            AlterColumn("dbo.BenhAns", "BenhNhanId", c => c.Int());
            DropColumn("dbo.BenhAns", "BenhId");
            RenameColumn(table: "dbo.BenhAns", name: "BenhNhanId", newName: "BenhNhan_BenhNhanId");
            CreateIndex("dbo.BenhAns", "BenhNhan_BenhNhanId");
            CreateIndex("dbo.BenhAns", "Benh_BenhId");
            AddForeignKey("dbo.BenhAns", "BenhNhan_BenhNhanId", "dbo.BenhNhans", "BenhNhanId");
            AddForeignKey("dbo.BenhAns", "Benh_BenhId", "dbo.Benhs", "BenhId");
        }
    }
}
