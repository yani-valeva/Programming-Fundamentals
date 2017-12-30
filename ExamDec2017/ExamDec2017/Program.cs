using System;

class Program
{
    static void Main(string[] args)
    {
        int regionAmount = int.Parse(Console.ReadLine());
        double density = double.Parse(Console.ReadLine());
        long raindropsCount = 0;
        long squareMeters = 0;
        double regionalCoefficient = 0.0;
        double sum = 0.0;

        for (int i = 0; i < regionAmount; i++)
        {
            string[] info = Console.ReadLine().Split();
            raindropsCount = long.Parse(info[0]);
            squareMeters = long.Parse(info[1]);
            regionalCoefficient = (double)raindropsCount / squareMeters;
            sum += regionalCoefficient;
        }
        
        if (density != 0)
        {
            Console.WriteLine("{0:f3}", sum / density);
        } 
        else
        {
            Console.WriteLine("{0:f3}", sum);
        }
    }
}