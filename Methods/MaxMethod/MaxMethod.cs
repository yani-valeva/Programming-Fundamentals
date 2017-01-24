using System;

class MaxMethod
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int biggerOfTwoNumbers = GetMax(firstNumber, secondNumber);
        int biggestOfThreeNumbers = GetMax(biggerOfTwoNumbers, thirdNumber);

        Console.WriteLine(biggestOfThreeNumbers);
    }

    public static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber >= secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
}
