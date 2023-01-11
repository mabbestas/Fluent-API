namespace Ornek1_TablolarArasiIliskiler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.Boolean(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
