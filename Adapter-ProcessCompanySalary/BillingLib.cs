using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_ProcessCompanySalary
{
    public class ThirdPartyBillingSystem
    {
        //ThirdPartyBillingSystem accepts employees information as a List to process each employee salary
        public void ProcessSalaryInAccount(List<Employee> listEmployee)
        {
            foreach (Employee employee in listEmployee)
            {
                Console.WriteLine("-->" + employee.Salary + "PKR Credited to " + employee.Name + " Account");
            }
        }
    }
}
