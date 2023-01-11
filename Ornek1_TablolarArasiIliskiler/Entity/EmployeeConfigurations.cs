using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1_TablolarArasiIliskiler.Entity
{
    public class EmployeeConfigurations : EntityTypeConfiguration<Employee>
    {
        // Table Splitting
        public EmployeeConfigurations()
        {

            //this.HasKey(x => x.EmployeeID)
            //    .ToTable("Employees");
            //this.HasEntitySetName<EmployeeContactDetail>    //???
            //    .HasKey(x => x.EmployeeID)
            //    .ToTable("Employees");
            //this.HasRequired(x => x.EmployeeContactDetails)
            //    .WithRequiredPrincipal(x => x.Employee);
        }
    }
}
