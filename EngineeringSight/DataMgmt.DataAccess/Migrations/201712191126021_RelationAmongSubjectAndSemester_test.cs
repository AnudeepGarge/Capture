namespace DataMgmt.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationAmongSubjectAndSemester_test : DbMigration
    {
        public override void Up()
        {
            //RenameIndex(table: "dbo.Branch_Semester", name: "Unique_KEY_Index", newName: "IX_BranchId_SemesterId");
        }
        
        public override void Down()
        {
            //RenameIndex(table: "dbo.Branch_Semester", name: "IX_BranchId_SemesterId", newName: "Unique_KEY_Index");
        }
    }
}
