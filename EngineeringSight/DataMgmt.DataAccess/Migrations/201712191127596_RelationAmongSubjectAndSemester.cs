namespace DataMgmt.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationAmongSubjectAndSemester : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subject_Semester",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        SemesterId = c.Int(nullable: false),
                        Branch_Semester_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch_Semester", t => t.Branch_Semester_Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => new { t.SemesterId, t.SubjectId }, unique: true)
                .Index(t => t.Branch_Semester_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subject_Semester", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Subject_Semester", "Branch_Semester_Id", "dbo.Branch_Semester");
            DropIndex("dbo.Subject_Semester", new[] { "Branch_Semester_Id" });
            DropIndex("dbo.Subject_Semester", new[] { "SemesterId", "SubjectId" });
            DropTable("dbo.Subject_Semester");
        }
    }
}
