using NUnit.Framework;
using printers.FizzBuzz;

namespace c_sharp_version.FizzBuzz
{
    [TestFixture]
    public class Runner
    {
        [Test]
        public void Run()
        {
            Problem.FizzBuzz();

            Assert.That(Console.GetCount(), Is.EqualTo(101), "user should have called print 100 times");
        }
    }
}