namespace MerazMVCReviewSiteProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Image");
        }
    }
}
