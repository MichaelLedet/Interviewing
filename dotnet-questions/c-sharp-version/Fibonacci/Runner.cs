using NUnit.Framework;
using printers.Fibonacci;

namespace c_sharp_version.Fibonacci
{
    [TestFixture]
    public class Runner
    {
        [Test]
        public void Run()
        {
            Problem.Fibonacci();

            Assert.That(Console.GetCount(), Is.EqualTo(16), "user should have called print 16 times");
        }
    }
}