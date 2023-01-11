using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1_TablolarArasiIliskiler.Entity
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }


        // Navigation Property
        public virtual List<Student> Students { get; set; }
    }
}
