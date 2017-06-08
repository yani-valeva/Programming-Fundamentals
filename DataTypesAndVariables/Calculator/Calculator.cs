using System;

public class Calculator
{
    public static void Main()
    {
        int firstOperand = int.Parse(Console.ReadLine());
        string operatorType = Console.ReadLine();
        int secondOperand = int.Parse(Console.ReadLine());
        PrintResult(operatorType, firstOperand, secondOperand);
    }

    private static void PrintResult(string operatorType, int firstOperand, int secondOperand)
    {
        switch (operatorType)
        {
            case "+":
                Console.WriteLine($"{firstOperand} + {secondOperand} = {firstOperand + secondOperand}");
                break;
            case "-":
                Console.WriteLine($"{firstOperand} - {secondOperand} = {firstOperand - secondOperand}");
                break;
            case "*":
                Console.WriteLine($"{firstOperand} * {secondOperand} = {firstOperand * secondOperand}");
                break;
            case "/":
                Console.WriteLine($"{firstOperand} / {secondOperand} = {firstOperand / secondOperand}");
                break;
        }
    }
}
