namespace FIT5032_Assignment_Portfolio_V1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addratingwithuseridkey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Ratings");
            AddColumn("dbo.Ratings", "RatingFeedback", c => c.String());
            AlterColumn("dbo.Ratings", "UserID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Ratings", "UserID");
            DropColumn("dbo.Ratings", "RatingID");
            DropColumn("dbo.Ratings", "ItemID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ratings", "ItemID", c => c.Int(nullable: false));
            AddColumn("dbo.Ratings", "RatingID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Ratings");
            AlterColumn("dbo.Ratings", "UserID", c => c.String());
            DropColumn("dbo.Ratings", "RatingFeedback");
            AddPrimaryKey("dbo.Ratings", "RatingID");
        }
    }
}
