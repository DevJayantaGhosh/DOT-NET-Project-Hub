using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestConsoleApp
{
    public static class SpecialSort
    {

        public static List<Employee> YourSortEmployee(List<Employee> list, Func<Employee,bool> logic)
        {
            List<Employee> newList = new List<Employee>();
            newList=list.Where(logic).ToList();
            return newList;
        }
    }
}
