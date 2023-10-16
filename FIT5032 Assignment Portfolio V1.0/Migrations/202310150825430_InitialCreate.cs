namespace FIT5032_Assignment_Portfolio_V1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        AppointmentDate = c.DateTime(nullable: false),
                        Patient_PatientId = c.Int(),
                        Report_ReportId = c.Int(),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.Patients", t => t.Patient_PatientId)
                .ForeignKey("dbo.Reports", t => t.Report_ReportId)
                .Index(t => t.Patient_PatientId)
                .Index(t => t.Report_ReportId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PatientId);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ReportId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReportId);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        UltrasoundImage = c.Binary(),
                        Report_ReportId = c.Int(),
                    })
                .PrimaryKey(t => t.ImageId)
                .ForeignKey("dbo.Reports", t => t.Report_ReportId)
                .Index(t => t.Report_ReportId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "Report_ReportId", "dbo.Reports");
            DropForeignKey("dbo.Images", "Report_ReportId", "dbo.Reports");
            DropForeignKey("dbo.Appointments", "Patient_PatientId", "dbo.Patients");
            DropIndex("dbo.Images", new[] { "Report_ReportId" });
            DropIndex("dbo.Appointments", new[] { "Report_ReportId" });
            DropIndex("dbo.Appointments", new[] { "Patient_PatientId" });
            DropTable("dbo.Images");
            DropTable("dbo.Reports");
            DropTable("dbo.Patients");
            DropTable("dbo.Appointments");
        }
    }
}
