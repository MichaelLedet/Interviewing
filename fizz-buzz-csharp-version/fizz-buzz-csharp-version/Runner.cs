using fizz_buzz_printer;
using NUnit.Framework;

namespace fizz_buzz_csharp_version
{
    [TestFixture]
    public class Runner
    {
        [Test]
        public void RunFizzBuzz()
        {
            var fizzBuzzer = new FizzBuzzProblem();

            fizzBuzzer.FizzBuzz();

            Assert.That(TestConsole.Counter, Is.EqualTo(101), "user should have called print 100 times");
        }
    }
}