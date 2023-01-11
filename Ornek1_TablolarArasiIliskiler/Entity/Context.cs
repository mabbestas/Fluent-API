using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1_TablolarArasiIliskiler.Entity
{
    public class Context : DbContext
    {
        public Context() : base()
        {
            Database.SetInitializer<Context>(new ContextInitializer());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Tablo isimlerini oluştururken otomatik olarak isimleri çoğul yapmasını engeller.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new CategoryConfiguration());

            modelBuilder
                .Entity<Category>()
                .HasKey(x => x.ID)
                .ToTable("Kategori");

            modelBuilder.Entity<Category>()
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("KategoriAdi")
                .HasColumnOrder(2)
                .HasColumnType("nvarchar");


            modelBuilder.Entity<AppUser>()
                .Map(x =>
                {
                x.Properties(y => new { y.ID, y.UserName, y.Password });
                x.ToTable("UserAccountInfo");
                })
                .Map(x =>
                {
                    x.Properties(y => new { y.ID, y.Adress, y.ContactNumber });
                    x.ToTable("UserContactDetails");
                });

            modelBuilder.Entity<AppUser>().Ignore(c => c.Email);




            // Many-to-Many Relation

            modelBuilder.Entity<Teacher>()
                .HasMany(x => x.Students)
                .WithMany(x => x.Teachers)
                .Map(y =>
                {
                    y.ToTable("TeacherStudents");
                    y.MapLeftKey("TeacherID");
                    y.MapRightKey("StudentID");
                });




            // Table Splitting

            modelBuilder.Entity<Employee>()
                .HasKey(x => x.EmployeeID)
                .ToTable("Employees");
            modelBuilder.Entity<EmployeeContactDetail>()
                .HasKey(x => x.EmployeeID)
                .ToTable("Employees");
            modelBuilder.Entity<Employee>()
                .HasRequired(x => x.EmployeeContactDetail).WithRequiredPrincipal(x => x.Employee);


            //modelBuilder.Configurations.Add(new EmployeeConfigurations());

            base.OnModelCreating(modelBuilder);  // silinmeyecek
        }
    }
}
