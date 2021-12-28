namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BenhNhanChange1ntoBenhAn : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Benhs", "BenhNhan_BenhNhanId", "dbo.BenhNhans");
            DropIndex("dbo.Benhs", new[] { "BenhNhan_BenhNhanId" });
            DropColumn("dbo.Benhs", "BenhNhan_BenhNhanId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Benhs", "BenhNhan_BenhNhanId", c => c.Int());
            CreateIndex("dbo.Benhs", "BenhNhan_BenhNhanId");
            AddForeignKey("dbo.Benhs", "BenhNhan_BenhNhanId", "dbo.BenhNhans", "BenhNhanId");
        }
    }
}
