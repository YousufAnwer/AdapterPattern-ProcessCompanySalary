using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_ProcessCompanySalary
{
    public interface ISalaryService
    {
        void ProcessEmployeesSalary(string[,] employeesArray);
    }
}
