using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uProfiler.Stopwatch
{
    /// <summary>
    /// Stopwatch for measuring execution time
    /// </summary>
    public interface IStopwatch
    {
        void Start();
        void Stop();
        long ElapsedMilliseconds { get; }
    }
}
