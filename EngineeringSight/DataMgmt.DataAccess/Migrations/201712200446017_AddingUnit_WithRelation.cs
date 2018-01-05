namespace DataMgmt.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUnit_WithRelation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CreationInfo_CreatedOn = c.Long(nullable: false),
                        CreationInfo_UpdatedOn = c.Long(nullable: false),
                        CreationInfo_Description = c.String(nullable: false, maxLength: 127),
                        SubjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SubjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Units", "SubjectId", "dbo.Subjects");
            DropIndex("dbo.Units", new[] { "SubjectId" });
            DropTable("dbo.Units");
        }
    }
}
