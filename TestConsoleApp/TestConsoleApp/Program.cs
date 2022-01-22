using System;
using System.Collections.Generic;
using System.Linq;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //List of Employees and sort them based on the salary
            Employee e1 = new Employee
            {
                EId = 10,
                EmpName = "Jaya",
                Salary = 1500
            };
            Employee e2 = new Employee
            {
                EId = 40,
                EmpName = "Jayak",
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

            List<Employee> list = new List<Employee>();
            list.Add(e1);
            list.Add(e2);
            list.Add(e3);
            list.Add(e4);
            list.Add(e5);
            list.Add(e6);
            foreach (Employee e in list)
            {
                Console.WriteLine(e.EId + "==" + e.EmpName);
            }
            Console.WriteLine("================================================");
            //  List<Employee> ans = list.OrderBy(e => e.EId).ToList();
            // List<Employee>
            // HashSet<Employee> employees
            //Dictionary<string,int> map
            SortedDictionary<String, int> treemap = new SortedDictionary<string, int>();

            List<Employee> ans = list.Where(x => x.Salary < 2000).ToList();
            ans.ForEach(x => Console.WriteLine(x.EId + "=="+x.EmpName));


            Func<Employee, bool> mylogic = (e) =>
             {
                 if (e.EId > 50)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             };

            
            list.Sort((x, y) => x.EId.CompareTo(y.EId));//IComparable  IComparer impl this into a class 

            Func<Employee, Employee, int> myComp = (a, b) =>
              {
                  return a.EId - b.EId;

              };

           

            List<Employee> finalans = SpecialSort.YourSortEmployee(list, (x)=>x.EId>80);
            finalans.ForEach(x => Console.WriteLine(x.EId));
            Console.ReadLine();
        }
    }

    
}
