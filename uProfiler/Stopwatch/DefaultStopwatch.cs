namespace uProfiler.Stopwatch
{
    /// <summary>
    /// Default IStopwatch implementation using System.Diagnostics.Stopwatch
    /// </summary>
    class DefaultStopwatch: IStopwatch
    {
        private readonly System.Diagnostics.Stopwatch _stopwatch;

        public DefaultStopwatch()
        {
            _stopwatch = new System.Diagnostics.Stopwatch();
        }
        public void Start()
        {
            _stopwatch.Start();
        }

        public void Stop()
        {
            _stopwatch.Stop();
        }

        public long ElapsedMilliseconds { get { return _stopwatch.ElapsedMilliseconds; } }
    }
}
