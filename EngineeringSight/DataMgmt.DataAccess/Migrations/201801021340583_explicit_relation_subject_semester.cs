namespace DataMgmt.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class explicit_relation_subject_semester : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Subject_Semester", "Branch_Semester_Id", "dbo.Branch_Semester");
            DropIndex("dbo.Subject_Semester", new[] { "SemesterId", "SubjectId" });
            DropIndex("dbo.Subject_Semester", new[] { "Branch_Semester_Id" });
            DropColumn("dbo.Subject_Semester", "SemesterId");
            RenameColumn(table: "dbo.Subject_Semester", name: "Branch_Semester_Id", newName: "SemesterId");
            AlterColumn("dbo.Subject_Semester", "SemesterId", c => c.Int(nullable: false));
            CreateIndex("dbo.Subject_Semester", new[] { "SemesterId", "SubjectId" }, unique: true);
            AddForeignKey("dbo.Subject_Semester", "SemesterId", "dbo.Branch_Semester", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subject_Semester", "SemesterId", "dbo.Branch_Semester");
            DropIndex("dbo.Subject_Semester", new[] { "SemesterId", "SubjectId" });
            AlterColumn("dbo.Subject_Semester", "SemesterId", c => c.Int());
            RenameColumn(table: "dbo.Subject_Semester", name: "SemesterId", newName: "Branch_Semester_Id");
            AddColumn("dbo.Subject_Semester", "SemesterId", c => c.Int(nullable: false));
            CreateIndex("dbo.Subject_Semester", "Branch_Semester_Id");
            CreateIndex("dbo.Subject_Semester", new[] { "SemesterId", "SubjectId" }, unique: true);
            AddForeignKey("dbo.Subject_Semester", "Branch_Semester_Id", "dbo.Branch_Semester", "Id");
        }
    }
}
