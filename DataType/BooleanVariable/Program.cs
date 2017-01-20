using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(word);

            Console.WriteLine(isTrue ? "Yes" : "No");
        }
    }
}
