using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (char firstLetter = 'a'; firstLetter < 'a' + number; firstLetter++)
            {
                for (char secondLetter = 'a'; secondLetter < 'a' + number; secondLetter++)
                {
                    for (char thirdLetter = 'a'; thirdLetter < 'a' + number; thirdLetter++)
                    {
                        Console.WriteLine("{0}{1}{2}", firstLetter, secondLetter, thirdLetter);
                    }
                }
            }
        }
    }
}
