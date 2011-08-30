using System;
using NUnit.Framework;

namespace fizz_buzz_printer
{
    public class TestConsole
    {
        public static int Counter = 1;

        public static void Print(string message)
        {
            if (Counter % 3 == 0 && Counter % 5 == 0)
                Assert.That( message, Is.EqualTo("FizzBuzz"), "expected FizzBuzz and got " + message );    
            else if (Counter % 3 == 0)
                Assert.That( message, Is.EqualTo("Fizz"), "expected Fizz and got " + message );    
            else if (Counter % 5 == 0)
                Assert.That( message, Is.EqualTo("Buzz"), "expected Buzz and got " + message );    
            else
                Assert.That( Convert.ToInt32(message), Is.EqualTo(Counter), "expected " + Counter + " and got " + message );
            Counter++;
        }
    }
}
