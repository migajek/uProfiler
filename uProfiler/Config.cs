using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uProfiler.Stopwatch;
using uProfiler.Targets;

namespace uProfiler
{
    /// <summary>
    /// Static class for storing DefaultSettings.
    /// </summary>
    public static class Config
    {
        public static Settings DefaultSettings { get; set; }

        static Config()
        {
            DefaultSettings = new Settings()
            {
                StopwatchType = typeof (DefaultStopwatch),
                TargetType = typeof (ConsoleTarget)
            };
        }
    }
}
