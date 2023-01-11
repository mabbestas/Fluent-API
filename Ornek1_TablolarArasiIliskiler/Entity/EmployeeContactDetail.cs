using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1_TablolarArasiIliskiler.Entity
{
    public class EmployeeContactDetail
    {
        public int EmployeeID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }

        // Navigation Property

        public Employee Employee { get; set; }
    }
}
