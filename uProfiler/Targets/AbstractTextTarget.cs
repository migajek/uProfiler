using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uProfiler.Targets
{
    /// <summary>
    /// Abstract text target, for writing string logs
    /// </summary>
    public abstract class AbstractTextTarget: ITarget
    {
        public void WriteResult(string name, long elapsed)
        {
            WriteResult(String.Format("{0} done in {1} ms", name, elapsed));
        }

        protected abstract void WriteResult(string result);
    }
}
