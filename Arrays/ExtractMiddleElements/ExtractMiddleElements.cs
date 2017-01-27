using System;
using System.Linq;

public class ExtractMiddleElements
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        PrintMiddleElements(numbers);
    }

    public static void PrintMiddleElements(int[] numbers)
    {
        int length = numbers.Length;

        if (length == 1)
        {
            Console.WriteLine($"{{ {numbers[0]} }}");
        }
        else if (length % 2 == 0)
        {
            Console.WriteLine($"{{ {numbers[(length / 2) - 1]}, {numbers[length / 2]} }}");
        }
        else if (length % 2 == 1)
        {
            Console.WriteLine($"{{ {numbers[(length / 2) - 1]}, {numbers[length / 2]}, {numbers[(length / 2) + 1]} }}");
        }
    }
}
