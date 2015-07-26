using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uProfiler.Targets
{
    /// <summary>
    /// Target that writes to Console
    /// </summary>
    public class ConsoleTarget: AbstractTextTarget
    {
        protected override void WriteResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
