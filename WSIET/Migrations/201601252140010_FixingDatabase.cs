namespace WSIET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VisitModels", "Location_LocationId", "dbo.LocationModels");
            DropIndex("dbo.VisitModels", new[] { "Location_LocationId" });
            AlterColumn("dbo.VisitModels", "Location_LocationId", c => c.Int(nullable: false));
            CreateIndex("dbo.VisitModels", "Location_LocationId");
            AddForeignKey("dbo.VisitModels", "Location_LocationId", "dbo.LocationModels", "LocationId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VisitModels", "Location_LocationId", "dbo.LocationModels");
            DropIndex("dbo.VisitModels", new[] { "Location_LocationId" });
            AlterColumn("dbo.VisitModels", "Location_LocationId", c => c.Int());
            CreateIndex("dbo.VisitModels", "Location_LocationId");
            AddForeignKey("dbo.VisitModels", "Location_LocationId", "dbo.LocationModels", "LocationId");
        }
    }
}
