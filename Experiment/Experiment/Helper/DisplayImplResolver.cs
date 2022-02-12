using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Experiment.Helper
{
    public class DisplayImplResolver : IDisplayImplResolver
    {
        private readonly IServiceProvider _serviceProvider;

        public DisplayImplResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IDisplay GetDisplayImplByName(string key)
        {
           // var allImplementatonOfIDisplay = _serviceProvider.GetServices<IDisplay>();
            if(!String.IsNullOrEmpty(key) && key.Equals("CONSOLE"))
            {
                Console.WriteLine("ConsoleDisplay initiating -=-===-=");
                return _serviceProvider.GetService<ConsoleDisplay>();
            }
            else
            {
                Console.WriteLine("AppDisplay initiating -=-===-=");
                return _serviceProvider.GetService<AppDisplay>();
            }
        }
    }
}
