﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            decimal sum = 0;
             
            for (int i = 0; i < numberCount; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
