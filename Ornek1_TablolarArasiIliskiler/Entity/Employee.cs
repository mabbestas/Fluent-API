using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1_TablolarArasiIliskiler.Entity
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Gender { get; set; }
        // public bool IsMen { get; set; }


        // Navigation Property

        public EmployeeContactDetail EmployeeContactDetail { get; set; }
    }
}
