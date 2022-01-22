using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestConsoleApp
{
    public class CharFreq
    {
        public static void Main()
        {
            string ans = "AaBBCCDDEEE";

            Console.WriteLine(ans);
            char[] charArr = ans.ToCharArray();
            IDictionary<char, int> freqMap = new Dictionary<char, int>();

            foreach(char c in charArr)
            {
                if (freqMap.ContainsKey(c) == false)
                {
                    freqMap.Add(c, 1);
                }
                else
                {
                    freqMap[c]+=1;
                }
            }

            foreach(KeyValuePair<char,int> map in freqMap)
            {
                Console.WriteLine(map.Key +"=="+map.Value);

            }

            Anagaram.Ana();

            SingleTonMy s = SingleTonMy.GiveMeInstance();
            SingleTonMy s2 = SingleTonMy.GiveMeInstance();

            Console.WriteLine(s.GetHashCode());
            Console.WriteLine(s2.GetHashCode());


            Console.ReadLine();
        }
    }
}
