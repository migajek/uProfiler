using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uProfiler.Stopwatch;
using uProfiler.Targets;

namespace uProfiler
{
    public class MicroProfiler : IDisposable
    {
        private readonly IStopwatch _stopwatch;
        private readonly ITarget _target;

        public long ElapsedMilliseconds { get; protected set; }
        public string Name { get; private set; }

        public MicroProfiler(string name = null, IStopwatch stopwatch = null, ITarget target = null, Settings settings = null)
        {
            Name = name;
            if (settings == null)
                settings = Config.DefaultSettings;

            _stopwatch = stopwatch ?? settings.StopwatchInstance ?? Activator.CreateInstance(settings.StopwatchType) as IStopwatch;
            _target = target ?? settings.TargetInstance ?? Activator.CreateInstance(settings.TargetType) as ITarget;

            Start();
        }

        public void Start()
        {
            _stopwatch.Start();
        }

        public void Dispose()
        {
            Stop(true);
        }

        public void Stop(bool writeToOutput)
        {
            _stopwatch.Stop();
            ElapsedMilliseconds = _stopwatch.ElapsedMilliseconds;
            if (writeToOutput)
                _target.WriteResult(Name, ElapsedMilliseconds);
        }
    }
}
