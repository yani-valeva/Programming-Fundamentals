using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitOrVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();

            if (symbol == "a" || symbol == "e" || symbol == "i" || symbol =="o" || symbol == "u")
            {
                Console.WriteLine("vowel");
            }
            else if (symbol == "0" || symbol == "1" || symbol == "2" || symbol == "3" || symbol == "4" || symbol == "5" || symbol == "6" || symbol == "7" || symbol == "8" || symbol == "9")
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
