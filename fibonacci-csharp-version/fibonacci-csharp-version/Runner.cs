using ficonacci_printer;
using NUnit.Framework;

namespace fibonacci_csharp_version
{
    [TestFixture]
    public class Runner
    {
        [Test]
        public void Fibonacci()
        {
            FibonacciProblem.Fibonacci();

            Assert.That(TestConsole.Counter, Is.EqualTo(16), "user should have called print 15 times");
        }
    }
}