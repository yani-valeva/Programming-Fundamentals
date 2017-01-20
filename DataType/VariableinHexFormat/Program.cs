using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberInHexFormat = Console.ReadLine();
            int numberInDecFormat = Convert.ToInt32(numberInHexFormat, 16);

            Console.WriteLine(numberInDecFormat);
        }
    }
}
