namespace HospitalManagement_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengthOnNames : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Patient", name: "FirstMidName", newName: "FirstName");
            AlterColumn("dbo.Patient", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Patient", "FirstName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patient", "FirstName", c => c.String());
            AlterColumn("dbo.Patient", "LastName", c => c.String());
            RenameColumn(table: "dbo.Patient", name: "FirstName", newName: "FirstMidName");
        }
    }
}
