using System;

public class DrawX
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
   
        int innerSpaces = number - 2;
        int leftRightSpaces = 0;

        for (int i = 1; i <= number/ 2; i++)
        {
            Console.WriteLine("{0}x{1}x{0}", new string(' ', leftRightSpaces), new string(' ', innerSpaces));
            innerSpaces -= 2;
            leftRightSpaces++;
        }

        int spaces = (number - 1) / 2;

        Console.WriteLine("{0}x{0}", new string(' ', spaces));

        innerSpaces += 2;
        leftRightSpaces--;

        for (int i = 1; i <= number / 2; i++)
        {
            Console.WriteLine("{0}x{1}x{0}", new string(' ', leftRightSpaces), new string(' ', innerSpaces));
            innerSpaces += 2;
            leftRightSpaces--;
        }
    }
}
