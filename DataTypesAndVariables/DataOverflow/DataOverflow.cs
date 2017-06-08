using System;
using System.Collections.Generic;
using System.Linq;

public class DataOverflow
{
    public static void Main()
    {
        ulong firstNumber = ulong.Parse(Console.ReadLine());
        ulong secondNumber = ulong.Parse(Console.ReadLine());

        ulong max = Math.Max(firstNumber, secondNumber);
        ulong min = Math.Min(firstNumber, secondNumber);
        var biggerTypeAndValue = GetType(max);
        string biggerType = biggerTypeAndValue.Keys.First();
        var smallerTypeAndValue = GetType(min);
        string smallerType = smallerTypeAndValue.Keys.First();
        var smallerMaxValue = smallerTypeAndValue.Values.First();
        var overflowTimes = Math.Round((decimal)max / smallerMaxValue);

        Console.WriteLine($"bigger type: {biggerType}");
        Console.WriteLine($"smaller type: {smallerType}");
        Console.WriteLine($"{max} can overflow {smallerType} {overflowTimes} times");
    }

    private static Dictionary<string, ulong> GetType(decimal number)
    {
        string type = string.Empty;
        ulong currentMaxValue = 0;

        if (byte.MinValue <= number && number <= byte.MaxValue)
        {
            type = "byte";
            currentMaxValue = byte.MaxValue;
        } 
        else if (ushort.MinValue <= number && number <= ushort.MaxValue)
        {
            type = "ushort";
            currentMaxValue = ushort.MaxValue;
        }
        else if (uint.MinValue <= number && number <= uint.MaxValue)
        {
            type = "uint";
            currentMaxValue = uint.MaxValue;
        }
        else if (ulong.MinValue <= number && number <= ulong.MaxValue)
        {
            type = "ulong";
            currentMaxValue = ulong.MaxValue;
        }

        Dictionary<string, ulong> typeAndValue = new Dictionary<string, ulong>();
        typeAndValue.Add(type, currentMaxValue);
        return typeAndValue;
    }
}
