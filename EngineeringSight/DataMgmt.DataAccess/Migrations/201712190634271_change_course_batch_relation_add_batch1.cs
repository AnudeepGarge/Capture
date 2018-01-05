namespace DataMgmt.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_course_batch_relation_add_batch1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Course_Branch", "FK_dbo.Course_Branch_dbo.University_Course_CourseId");
            AddForeignKey("dbo.Course_Branch", "CourseId", "Course_Syllabus_Change_Batch");
        }
        
        public override void Down()
        {
        }
    }
}
