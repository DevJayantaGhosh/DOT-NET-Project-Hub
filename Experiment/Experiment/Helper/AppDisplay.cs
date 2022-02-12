using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Experiment.Helper
{
    public class AppDisplay : IDisplay
    {
        public void show()
        {
            Console.WriteLine("-=-==-== This is app Display=-=-=-=-");
        }
    }
}
