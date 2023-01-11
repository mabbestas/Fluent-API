using System.Data.Entity.ModelConfiguration;

namespace Ornek1_TablolarArasiIliskiler.Entity
{
    internal class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            this.HasKey(x => x.ID)
               .ToTable("Kategori");

            this.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("KategoriAdi")
                .HasColumnOrder(2)
                .HasColumnType("nvarchar");
        }
    }
}