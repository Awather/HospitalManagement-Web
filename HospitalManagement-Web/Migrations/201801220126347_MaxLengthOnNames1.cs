namespace HospitalManagement_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengthOnNames1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Patient", name: "FirstName", newName: "FirstMidName");
            AlterColumn("dbo.Patient", "LastName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patient", "LastName", c => c.String());
            RenameColumn(table: "dbo.Patient", name: "FirstMidName", newName: "FirstName");
        }
    }
}
