using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp
{
    public class VoterApp
    {
        public static void Main(string[] args)
        {
            Voter v = new Voter();
            v.Age = 15;
            v.VoterName = "Jay";

            Voter v1 = new Voter();
            v1.Age = 25;
            v1.VoterName = "Jayanta";


            Voter v2 = new Voter();
            v2.Age = 15;
            v2.VoterName = "Jay3";

            Voter v3 = new Voter();
            v3.Age = 15;
            v3.VoterName = "Jay4";
            List<Voter> list = new List<Voter>();
            list.Add(v);
            list.Add(v1);
            list.Add(v2);
            list.Add(v3);

             List<Voter> ShortListedVoter(List<Voter> inputList,Func<Voter,bool> logic)
            {
                List<Voter> ans = new List<Voter>();
                inputList.ForEach(x =>
                {
                    if (logic(x))
                    {
                        ans.Add(x);
                    }
                });
                return ans;
            }


            Func<Voter, bool> greater18Logic = (v) => {
                if (v.Age > 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            List<Voter> finalAns = ShortListedVoter(list, greater18Logic);

            finalAns.ForEach(x => Console.WriteLine(x.VoterName + "----" + x.Age));

            List<Voter> finalAns2 = ShortListedVoter(list, (a)=>a.Age>10);
            Console.WriteLine("=============");

            finalAns2.ForEach(x => Console.WriteLine(x.VoterName + "----" + x.Age));



        } 
    }
}
