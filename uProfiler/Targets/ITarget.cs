using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uProfiler.Targets
{
    public interface ITarget
    {
        void WriteResult(string name, long elapsed);
    }
}
