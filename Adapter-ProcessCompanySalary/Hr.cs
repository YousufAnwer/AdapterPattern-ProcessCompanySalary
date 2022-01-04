using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_ProcessCompanySalary
{
    public class Hr 
    {
        private string[,] employeesArray = new string[5, 4]
           {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
           };
        public string[,] SendEmployeeData()
        {
            return employeesArray;
        }
    }
}
