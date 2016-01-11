namespace WSIET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LocationModels",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        BaseType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LocationId);
            
            CreateTable(
                "dbo.VisitModels",
                c => new
                    {
                        VisitId = c.Int(nullable: false, identity: true),
                        User_FirstName = c.String(),
                        User_LastName = c.String(),
                        User_EmailAddress = c.String(),
                        Rating = c.Int(nullable: false),
                        Review = c.String(),
                        Date = c.DateTime(nullable: false),
                        Location_LocationId = c.Int(),
                    })
                .PrimaryKey(t => t.VisitId)
                .ForeignKey("dbo.LocationModels", t => t.Location_LocationId)
                .Index(t => t.Location_LocationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VisitModels", "Location_LocationId", "dbo.LocationModels");
            DropIndex("dbo.VisitModels", new[] { "Location_LocationId" });
            DropTable("dbo.VisitModels");
            DropTable("dbo.LocationModels");
        }
    }
}
