using Adapter_ProcessCompanySalary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_ProcessCompanySalary
{
    /// <summary>
    /// The main Issue is this system uses a 3rd Party Billing Libray to process salary into employees account
    /// but this orginization has data in 2Darray format
    /// to solve this 
    /// creating SalaryAdapter which has Array2ListWrapper to solve prolem
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Hr hr = new Hr();
            string[,] employeesData = hr.SendEmployeeData();


            Console.WriteLine("HR system passes employee string array to Adapter\n");
            ISalaryService salaryService = new SalaryAdapter();
            salaryService.ProcessEmployeesSalary(employeesData);
            Console.Read();
        }
    }
   

}


