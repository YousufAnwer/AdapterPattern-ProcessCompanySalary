using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_ProcessCompanySalary
{

    public class SalaryAdapter : ThirdPartyBillingSystem, ISalaryService
    {
        public void ProcessEmployeesSalary(string[,] employeesArray)
        {
            Array2ListWrapper(employeesArray);
        }
        private void Array2ListWrapper(string[,] employeesArray)
        {
            Employee emp;
            List<Employee> listEmployee = new List<Employee>();
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                emp = new Employee();
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        emp.ID = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        emp.Name = employeesArray[i, j];
                    }
                    else if (j == 2)
                    {
                        emp.Designation = employeesArray[i, j];
                    }
                    else
                    {
                        emp.Salary = employeesArray[i, j];
                    }
                }
                listEmployee.Add(emp);
            }

            Console.WriteLine("Adapter converted Array of Employee to List of Employee");
            Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
            ProcessSalaryInAccount(listEmployee);
        }

    }
}
