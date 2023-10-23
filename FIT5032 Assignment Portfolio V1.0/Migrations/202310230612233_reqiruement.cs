namespace FIT5032_Assignment_Portfolio_V1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reqiruement : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "userid", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "userid", c => c.String());
        }
    }
}
