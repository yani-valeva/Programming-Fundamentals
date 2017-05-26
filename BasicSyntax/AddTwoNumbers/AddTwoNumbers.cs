using System;

public class AddTwoNumbers
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int sum = firstNumber + secondNumber;

        Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
    }
}
