namespace FIT5032_Assignment_Portfolio_V1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "userid", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "userid");
        }
    }
}
