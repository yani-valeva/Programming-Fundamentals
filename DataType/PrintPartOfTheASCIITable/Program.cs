using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                char currentChar = Convert.ToChar(i);
                Console.Write(currentChar + " ");
            }
            Console.WriteLine();
        }
    }
}
