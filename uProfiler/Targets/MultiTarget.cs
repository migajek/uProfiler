using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uProfiler.Targets
{
    /// <summary>
    /// Writes to every ITarget added to the list
    /// </summary>
    public class MultiTarget: List<ITarget>, ITarget
    {
        public void WriteResult(string name, long elapsed)
        {
            foreach (var target in this)
            {
                target.WriteResult(name, elapsed);
            }
        }
    }
}
