using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Experiment.Helper
{
    public interface IDisplayImplResolver
    {
        IDisplay GetDisplayImplByName(string key);
    }
}
