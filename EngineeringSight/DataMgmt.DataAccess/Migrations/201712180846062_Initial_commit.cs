namespace DataMgmt.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_commit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 63),
                        CreationInfo_CreatedOn = c.Long(nullable: false),
                        CreationInfo_UpdatedOn = c.Long(nullable: false),
                        CreationInfo_Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Course_Branch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        BranchCode = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.University_Course", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.University_Course",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        UniversityId = c.Int(nullable: false),
                        CourseCode = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Universities", t => t.UniversityId, cascadeDelete: true)
                .Index(t => new { t.UniversityId, t.CourseId }, unique: true, name: "University_CourseIndex");
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 63),
                        CourseCode = c.String(maxLength: 23),
                        Synonyms = c.String(maxLength: 31),
                        CreationInfo_CreatedOn = c.Long(nullable: false),
                        CreationInfo_UpdatedOn = c.Long(nullable: false),
                        CreationInfo_Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(nullable: false, maxLength: 63),
                        CreationInfo_CreatedOn = c.Long(nullable: false),
                        CreationInfo_UpdatedOn = c.Long(nullable: false),
                        CreationInfo_Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Course_Branch", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.University_Course", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.University_Course", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Course_Branch", "CourseId", "dbo.University_Course");
            DropIndex("dbo.University_Course", "University_CourseIndex");
            DropIndex("dbo.Course_Branch", new[] { "BranchId" });
            DropIndex("dbo.Course_Branch", new[] { "CourseId" });
            DropTable("dbo.Universities");
            DropTable("dbo.Courses");
            DropTable("dbo.University_Course");
            DropTable("dbo.Course_Branch");
            DropTable("dbo.Branches");
        }
    }
}
