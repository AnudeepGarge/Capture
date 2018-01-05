namespace DataMgmt.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adding_basic_subject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 63),
                        SubjectCode = c.String(nullable: false, maxLength: 23),
                        CreationInfo_CreatedOn = c.Long(nullable: false),
                        CreationInfo_UpdatedOn = c.Long(nullable: false),
                        CreationInfo_Description = c.String(nullable: false, maxLength: 127),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subjects");
        }
    }
}
