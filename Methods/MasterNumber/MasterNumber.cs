using System;

class MasterNumber
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        PrintMasterNumber(number);
    }

    public static void PrintMasterNumber(int number)
    {
        for (int currentNumber = 1; currentNumber <= number; currentNumber++)
        {
            bool isPalindome = IsPalindrome(currentNumber);
            bool isDivisibleBySeven = IsSumOfDigitsDivisibleBySeven(currentNumber);
            bool hasEvenDigit = ContainsEvenDigit(currentNumber);

            if (isPalindome && isDivisibleBySeven && hasEvenDigit)
            {
                Console.WriteLine(currentNumber);
            }
        }       
    }

    public static bool ContainsEvenDigit(int currentNumber)
    {
        bool hasEvenDigit = false;

        while (currentNumber > 0)
        {
            int digit = currentNumber % 10;
            if(digit % 2 == 0)
            {
                hasEvenDigit = true;
                break;
            }

            currentNumber /= 10;
        }
        return hasEvenDigit;
    }

    public static bool IsSumOfDigitsDivisibleBySeven(int currentNumber)
    {
        int sum = 0;

        while (currentNumber > 0)
        {
            int digit = currentNumber % 10;
            sum += digit;
            currentNumber /= 10;
        }

        bool isDivisibleBySeven = false;

        if(sum % 7 == 0)
        {
            isDivisibleBySeven = true;
        }
        return isDivisibleBySeven;
    }

    public static bool IsPalindrome(int currentNumber)
    {
        string numberAsString = currentNumber.ToString();
        bool isPalindome = true;

        for (int i = 0; i < numberAsString.Length / 2; i++)
        {
            if (numberAsString[i] != numberAsString[numberAsString.Length - i - 1])
            {
                isPalindome = false;
                break;
            }
        }
        return isPalindome;
    }
}
