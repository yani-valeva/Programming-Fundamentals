using System;

class GreaterOfTwoValues
{
    public static void Main()
    {
        string type = Console.ReadLine();

        if (type == "int")
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(firstNumber, secondNumber));
        }
        else if (type == "char")
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(firstChar, secondChar));
        }
        else if (type == "string")
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            Console.WriteLine(GetMax(firstWord, secondWord));
        }
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

    public static char GetMax(char firstChar, char secondChar)
    {
        if (firstChar >= secondChar)
        {
            return firstChar;
        }
        else
        {
            return secondChar;
        }
    }

    public static string GetMax(string firstWord, string secondWord)
    {
        if (firstWord.CompareTo(secondWord) >= 0)
        {
            return firstWord;
        }
        else
        {
            return secondWord;
        }
    }
}
