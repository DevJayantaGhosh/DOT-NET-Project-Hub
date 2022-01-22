using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp
{
    public class Employee
    {
        public int EId { get; set; }
        public string EmpName { get; set; }
        public long Salary { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   EId == employee.EId &&
                   EmpName == employee.EmpName &&
                   Salary == employee.Salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(EId, EmpName, Salary);
        }
    }
}
