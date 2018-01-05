namespace DataMgmt.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_course_batch_relation_add_batch : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Batches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 127),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Course_Syllabus_Change_Batch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        BatchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Batches", t => t.BatchId, cascadeDelete: true)
                .ForeignKey("dbo.University_Course", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.BatchId);
            
            AlterColumn("dbo.Branches", "CreationInfo_Description", c => c.String(nullable: false, maxLength: 127));
            AlterColumn("dbo.Semesters", "CreationInfo_Description", c => c.String(nullable: false, maxLength: 127));
            AlterColumn("dbo.Courses", "CreationInfo_Description", c => c.String(nullable: false, maxLength: 127));
            AlterColumn("dbo.Universities", "CreationInfo_Description", c => c.String(nullable: false, maxLength: 127));
           
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Course_Syllabus_Change_Batch", "CourseId", "dbo.University_Course");
            DropForeignKey("dbo.Course_Syllabus_Change_Batch", "BatchId", "dbo.Batches");
            DropIndex("dbo.Course_Syllabus_Change_Batch", new[] { "BatchId" });
            DropIndex("dbo.Course_Syllabus_Change_Batch", new[] { "CourseId" });
            AlterColumn("dbo.Universities", "CreationInfo_Description", c => c.String());
            AlterColumn("dbo.Courses", "CreationInfo_Description", c => c.String());
            AlterColumn("dbo.Semesters", "CreationInfo_Description", c => c.String());
            AlterColumn("dbo.Branches", "CreationInfo_Description", c => c.String());
            DropTable("dbo.Course_Syllabus_Change_Batch");
            DropTable("dbo.Batches");
        }
    }
}
