using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1_TablolarArasiIliskiler.Entity
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }


        // Navigation Property
        public virtual List<Teacher> Teachers { get; set; }
    }
}
