namespace WSIET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocationName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LocationModels", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LocationModels", "Name");
        }
    }
}
