namespace Ornek1_TablolarArasiIliskiler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserAccountInfo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserContactDetails",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ContactNumber = c.String(),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserAccountInfo", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserContactDetails", "ID", "dbo.UserAccountInfo");
            DropIndex("dbo.UserContactDetails", new[] { "ID" });
            DropTable("dbo.UserContactDetails");
            DropTable("dbo.UserAccountInfo");
        }
    }
}
