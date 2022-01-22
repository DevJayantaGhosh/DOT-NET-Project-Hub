using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp
{
    public class MyHashCodeEqual
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hashcode and Equal Check ");
            Employee e1 = new Employee
            {
                EId = 10,
                EmpName = "Jaya",
                Salary = 1500
            };
            Employee e2 = new Employee
            {
                EId = 10,
                EmpName = "Jaya",
                Salary = 1500
            };
            Employee e3 = new Employee
            {
                EId = 80,
                EmpName = "AJaya",
                Salary = 1580
            };
            Employee e4 = new Employee
            {
                EId = 18,
                EmpName = "PuJaya",
                Salary = 6500
            };
            Employee e5 = new Employee
            {
                EId = 51,
                EmpName = "KalaJaya",
                Salary = 1540
            };
            Employee e6 = new Employee
            {
                EId = 90,
                EmpName = "RaJaya",
                Salary = 1508
            };

            HashSet<Employee> set = new HashSet<Employee>();
            set.Add(e1);
            set.Add(e2);
            set.Add(e3);
            set.Add(e4);
            set.Add(e5);
            set.Add(e6);

            foreach(Employee e in set)
            {
                Console.WriteLine(e.EId);
            }
            Console.ReadLine();


        }
    }
}
