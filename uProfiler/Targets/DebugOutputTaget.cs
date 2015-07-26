using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uProfiler.Targets
{
    /// <summary>
    /// Target that writes to Debug
    /// </summary>
    public class DebugOutputTaget: AbstractTextTarget
    {
        protected override void WriteResult(string result)
        {
            Debug.WriteLine(result);
        }
    }
}
