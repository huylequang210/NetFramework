namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateTimeToDateTime2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BenhAns", "StartDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.BenhAns", "EndDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.BenhNhans", "BirthDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BenhNhans", "BirthDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BenhAns", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BenhAns", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
