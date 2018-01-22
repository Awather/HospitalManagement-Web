namespace HospitalManagement_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Registration",
                c => new
                    {
                        RegistrationID = c.Int(nullable: false, identity: true),
                        DepartmentID = c.Int(nullable: false),
                        PatientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RegistrationID)
                .ForeignKey("dbo.Department", t => t.DepartmentID, cascadeDelete: true)
                .ForeignKey("dbo.Patient", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.DepartmentID)
                .Index(t => t.PatientID);
            
            CreateTable(
                "dbo.Patient",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SocialSecurityNumber = c.Int(nullable: false),
                        LastName = c.String(),
                        FirstMidName = c.String(),
                        Gender = c.String(),
                        Address = c.String(),
                        ZipCode = c.Int(nullable: false),
                        City = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registration", "PatientID", "dbo.Patient");
            DropForeignKey("dbo.Registration", "DepartmentID", "dbo.Department");
            DropIndex("dbo.Registration", new[] { "PatientID" });
            DropIndex("dbo.Registration", new[] { "DepartmentID" });
            DropTable("dbo.Patient");
            DropTable("dbo.Registration");
            DropTable("dbo.Department");
        }
    }
}
