namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BenhAnAddBenhNavigation : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.BenhAns", "BenhId");
            AddForeignKey("dbo.BenhAns", "BenhId", "dbo.Benhs", "BenhId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BenhAns", "BenhId", "dbo.Benhs");
            DropIndex("dbo.BenhAns", new[] { "BenhId" });
        }
    }
}
