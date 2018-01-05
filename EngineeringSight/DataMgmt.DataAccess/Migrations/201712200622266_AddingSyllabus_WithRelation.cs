namespace DataMgmt.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingSyllabus_WithRelation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Syllabus",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 127),
                        Detail = c.String(nullable: false, maxLength: 2047),
                        CreationInfo_CreatedOn = c.Long(nullable: false),
                        CreationInfo_UpdatedOn = c.Long(nullable: false),
                        CreationInfo_Description = c.String(nullable: false, maxLength: 127),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Units", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id);
            
            AlterColumn("dbo.Units", "Title", c => c.String(nullable: false, maxLength: 127));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Syllabus", "Id", "dbo.Units");
            DropIndex("dbo.Syllabus", new[] { "Id" });
            AlterColumn("dbo.Units", "Title", c => c.String());
            DropTable("dbo.Syllabus");
        }
    }
}
