using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            for (int number = 2; number <= numberCount; number++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {isPrime}");
            }
        }
    }
}
