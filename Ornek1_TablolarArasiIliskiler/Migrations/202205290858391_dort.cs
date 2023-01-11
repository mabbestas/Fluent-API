namespace Ornek1_TablolarArasiIliskiler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dort : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                    })
                .PrimaryKey(t => t.TeacherID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.TeacherStudents",
                c => new
                    {
                        TeacherID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeacherID, t.StudentID })
                .ForeignKey("dbo.Teacher", t => t.TeacherID, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.TeacherID)
                .Index(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherStudents", "StudentID", "dbo.Student");
            DropForeignKey("dbo.TeacherStudents", "TeacherID", "dbo.Teacher");
            DropIndex("dbo.TeacherStudents", new[] { "StudentID" });
            DropIndex("dbo.TeacherStudents", new[] { "TeacherID" });
            DropTable("dbo.TeacherStudents");
            DropTable("dbo.Student");
            DropTable("dbo.Teacher");
        }
    }
}
