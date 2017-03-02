using System;

namespace Nacepin
{
    public class Nacepin
    {
        public static void Main()
        {
            decimal usPrice = decimal.Parse(Console.ReadLine());
            long usBoxWeigth = long.Parse(Console.ReadLine());
            decimal ukPrice = decimal.Parse(Console.ReadLine());
            long ukBoxWeight = long.Parse(Console.ReadLine());
            decimal chinesePrice = decimal.Parse(Console.ReadLine());
            long chineseBoxWeight = long.Parse(Console.ReadLine());

            decimal usToLvPerKg = (usPrice / 0.58m) / usBoxWeigth;
            decimal ukToLvPerKg = (ukPrice / 0.41m) / ukBoxWeight;
            decimal chineseToLvPerKg = (chinesePrice * 0.27m) / chineseBoxWeight;

            if (usToLvPerKg < ukToLvPerKg && usToLvPerKg < chineseToLvPerKg)
            {
                Console.WriteLine($"US store. {usToLvPerKg:f2} lv/kg");
                decimal max = Math.Max(ukToLvPerKg, chineseToLvPerKg);
                decimal difference = max - usToLvPerKg;
                Console.WriteLine($"Difference {difference:f2} lv/kg");
            }
            else if (ukToLvPerKg < usToLvPerKg && ukToLvPerKg < chineseToLvPerKg)
            {
                Console.WriteLine($"Uk store. {ukToLvPerKg:f2} lv/kg");
                decimal max = Math.Max(usToLvPerKg, chineseToLvPerKg);
                decimal difference = max - ukToLvPerKg;
                Console.WriteLine($"Difference {difference:f2} lv/kg");
            }
            else if (chineseToLvPerKg < usToLvPerKg && chineseToLvPerKg < ukToLvPerKg)
            {
                Console.WriteLine($"Chinese store. {chineseToLvPerKg:f2} lv/kg");
                decimal max = Math.Max(usToLvPerKg, ukToLvPerKg);
                decimal difference = max - chineseToLvPerKg;
                Console.WriteLine($"Difference {difference:f2} lv/kg");
            }
        }
    }
}
