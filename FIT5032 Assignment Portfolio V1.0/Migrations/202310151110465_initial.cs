namespace FIT5032_Assignment_Portfolio_V1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "Patient_PatientId", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "Report_ReportId", "dbo.Reports");
            DropIndex("dbo.Appointments", new[] { "Patient_PatientId" });
            DropIndex("dbo.Appointments", new[] { "Report_ReportId" });
            AddColumn("dbo.Images", "Path", c => c.String());
            AlterColumn("dbo.Appointments", "Patient_PatientId", c => c.Int(nullable: false));
            AlterColumn("dbo.Appointments", "Report_ReportId", c => c.Int(nullable: false));
            AlterColumn("dbo.Patients", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Patients", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Patients", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Reports", "Description", c => c.String(nullable: false));
            CreateIndex("dbo.Appointments", "Patient_PatientId");
            CreateIndex("dbo.Appointments", "Report_ReportId");
            AddForeignKey("dbo.Appointments", "Patient_PatientId", "dbo.Patients", "PatientId", cascadeDelete: true);
            AddForeignKey("dbo.Appointments", "Report_ReportId", "dbo.Reports", "ReportId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "Report_ReportId", "dbo.Reports");
            DropForeignKey("dbo.Appointments", "Patient_PatientId", "dbo.Patients");
            DropIndex("dbo.Appointments", new[] { "Report_ReportId" });
            DropIndex("dbo.Appointments", new[] { "Patient_PatientId" });
            AlterColumn("dbo.Reports", "Description", c => c.String());
            AlterColumn("dbo.Patients", "Email", c => c.String());
            AlterColumn("dbo.Patients", "LastName", c => c.String());
            AlterColumn("dbo.Patients", "FirstName", c => c.String());
            AlterColumn("dbo.Appointments", "Report_ReportId", c => c.Int());
            AlterColumn("dbo.Appointments", "Patient_PatientId", c => c.Int());
            DropColumn("dbo.Images", "Path");
            CreateIndex("dbo.Appointments", "Report_ReportId");
            CreateIndex("dbo.Appointments", "Patient_PatientId");
            AddForeignKey("dbo.Appointments", "Report_ReportId", "dbo.Reports", "ReportId");
            AddForeignKey("dbo.Appointments", "Patient_PatientId", "dbo.Patients", "PatientId");
        }
    }
}
