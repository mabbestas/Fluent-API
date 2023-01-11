using System.Collections.Generic;
using System.Data.Entity;

namespace Ornek1_TablolarArasiIliskiler.Entity
{
    public class ContextInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            IList<Category> kategoriler = new List<Category>();
            kategoriler.Add(new Category() { Name = "Elektronik" });
            kategoriler.Add(new Category() { Name = "Otomotiv" });
            kategoriler.Add(new Category() { Name = "Tekstil" });

            context.Categories.AddRange(kategoriler);


            IList<Employee> calisanlar = new List<Employee>();
            calisanlar.Add(new Employee()
            {
                FirstName = "Burak",
                LastName = "Beştaş",
                Gender = true,
                EmployeeContactDetail = new EmployeeContactDetail
                {
                    Adress = "İstanbul",
                    Phone = "123456789",
                    Email = "gmail"
                }
            });

            calisanlar.Add(new Employee()
            {
                FirstName = "Ali",
                LastName = "Toplu",
                Gender = true,
                EmployeeContactDetail = new EmployeeContactDetail
                {
                    Adress = "İzmir",
                    Phone = "123456991",
                    Email = "hotmail"
                }
            });

            calisanlar.Add(new Employee()
            {
                FirstName = "Nazlı",
                LastName = "Yıldırım",
                Gender = true,
                EmployeeContactDetail = new EmployeeContactDetail
                {
                    Adress = "Ankara",
                    Phone = "553456789",
                    Email = "outlook"
                }
            });

            context.Employees.AddRange(calisanlar);

            IList<Student> ogrenciler = new List<Student>();
            ogrenciler.Add(new Student { StudentName = "Eyüp " });
            ogrenciler.Add(new Student { StudentName = "Enis " });
            ogrenciler.Add(new Student { StudentName = "Hande " });

            context.Students.AddRange(ogrenciler);

            IList<Teacher> ogretmenler = new List<Teacher>();
            ogretmenler.Add(new Teacher { TeacherName = "Zafer " });
            ogretmenler.Add(new Teacher { TeacherName = "Gizem " });
            ogretmenler.Add(new Teacher { TeacherName = "Burak " });

            context.Teachers.AddRange(ogretmenler);


            base.Seed(context);
        }
    }
}