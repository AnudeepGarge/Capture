namespace DataMgmt.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adding_semester : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branch_Semester",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchId = c.Int(nullable: false),
                        SemesterId = c.Int(nullable: false),
                        BranchCode = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Semesters", t => t.SemesterId, cascadeDelete: true)
                .ForeignKey("dbo.Course_Branch", t => t.BranchId, cascadeDelete: true)
                .Index(t => t.BranchId)
                .Index(t => t.SemesterId);
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationInfo_CreatedOn = c.Long(nullable: false),
                        CreationInfo_UpdatedOn = c.Long(nullable: false),
                        CreationInfo_Description = c.String(),
                        Synonyms = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Branch_Semester", "BranchId", "dbo.Course_Branch");
            DropForeignKey("dbo.Branch_Semester", "SemesterId", "dbo.Semesters");
            DropIndex("dbo.Branch_Semester", new[] { "SemesterId" });
            DropIndex("dbo.Branch_Semester", new[] { "BranchId" });
            DropTable("dbo.Semesters");
            DropTable("dbo.Branch_Semester");
        }
    }
}
