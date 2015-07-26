using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using uProfiler;
using uProfiler.Targets;

namespace Tests
{
    internal class CustomTarget : ITarget
    {
        public string Name { get; set; }
        public long Elapsed { get; set; }

        public void WriteResult(string name, long elapsed)
        {
            Name = name;
            Elapsed = elapsed;
        }
    }

    [TestFixture]
    public class UProfilerTests
    {
        [Test]
        public void DefaultSettings()
        {
            using (var profiler = new MicroProfiler())
            {
                Thread.Sleep(11);
                profiler.Stop(false);
                Assert.That(profiler.ElapsedMilliseconds, Is.GreaterThanOrEqualTo(10));
            }
        }

        [Test]
        public void CustomTarget()
        {
            var target = new CustomTarget();
            using (var profiler = new MicroProfiler("MyName", target: target))
            {
                Thread.Sleep(11);
            }
            Assert.That(target.Elapsed, Is.GreaterThanOrEqualTo(10));
            Assert.That(target.Name, Is.EqualTo("MyName"));
        }

        [Test]
        public void CustomMultiTarget()
        {
            var target = new MultiTarget()
            {
                new CustomTarget(),
                new CustomTarget()
            };
            using (var profiler = new MicroProfiler("MyName", target: target))
            {
                Thread.Sleep(11);
            }
            Assert.That(target.All(x => (x as CustomTarget).Elapsed >= 10), Is.True);
            Assert.That(target.All(x => (x as CustomTarget).Name == "MyName"), Is.True);
        }
    }
}
