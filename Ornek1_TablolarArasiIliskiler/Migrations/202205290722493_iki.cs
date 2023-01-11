namespace Ornek1_TablolarArasiIliskiler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iki : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Kategori", name: "Name", newName: "KategoriAdi");
            AlterColumn("dbo.Kategori", "KategoriAdi", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kategori", "KategoriAdi", c => c.String());
            RenameColumn(table: "dbo.Kategori", name: "KategoriAdi", newName: "Name");
        }
    }
}
