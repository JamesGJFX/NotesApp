namespace NotesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initalMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Note",
                c => new
                    {
                        NoteId = c.Int(nullable: false, identity: true),
                        NoteBody = c.String(),
                        Subject_SubjectId = c.Int(),
                    })
                .PrimaryKey(t => t.NoteId)
                .ForeignKey("dbo.Subject", t => t.Subject_SubjectId)
                .Index(t => t.Subject_SubjectId);
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                    })
                .PrimaryKey(t => t.SubjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Note", "Subject_SubjectId", "dbo.Subject");
            DropIndex("dbo.Note", new[] { "Subject_SubjectId" });
            DropTable("dbo.Subject");
            DropTable("dbo.Note");
        }
    }
}
