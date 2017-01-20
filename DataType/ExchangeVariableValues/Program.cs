﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Before:\na = {a}\nb = {b}");

            int oldA = a;
            a = b;
            b = oldA;

            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}
