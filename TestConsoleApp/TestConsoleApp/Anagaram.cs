using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp
{
    public class Anagaram
    {
        public static void Ana()
        {
            string str = "CAT";
            string str2 = "ACT";

            char[] arr1 = str.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);
            str = arr1.ToString();
            str2 = arr2.ToString();
            if (str.Equals(str2))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        } 
    }
}
