using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Experiment.Helper
{
    public class ConsoleDisplay : IDisplay
    {
        public void show()
        {
            Console.WriteLine("======This is from Console Display=======");
        }
    }
}
