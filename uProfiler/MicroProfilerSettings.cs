using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uProfiler.Stopwatch;
using uProfiler.Targets;

namespace uProfiler
{
    public class Settings
    {
        public Type StopwatchType { get; set; }
        public Type TargetType { get; set; }

        public IStopwatch StopwatchInstance { get; set; }
        public ITarget TargetInstance { get; set; }
    }
}
