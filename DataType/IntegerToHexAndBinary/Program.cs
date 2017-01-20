using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = int.Parse(Console.ReadLine());
            string hexValue = Convert.ToString(intValue, 16).ToUpper();
            string binaryValue = Convert.ToString(intValue, 2);

            Console.WriteLine(hexValue);
            Console.WriteLine(binaryValue);
        }
    }
}
