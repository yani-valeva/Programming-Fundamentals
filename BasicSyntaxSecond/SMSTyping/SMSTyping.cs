using System;
using System.Text;

public class SMSTyping
{
    public static void Main()
    {
        int charactersNumber = int.Parse(Console.ReadLine());
        StringBuilder sms = new StringBuilder();


        for (int i = 0; i < charactersNumber; i++)
        {
            string input = Console.ReadLine();

            if (input.Equals("0"))
            {
                sms.Append(" ");
                continue;
            }

            int digitsNumber = input.Length;
            int mainDigit = int.Parse(input[0].ToString());
            int offset = !(mainDigit == 8 || mainDigit == 9) ? (mainDigit - 2) * 3 : ((mainDigit - 2) * 3) + 1;
            int letterIndex = offset + digitsNumber - 1;
            char currentLetter = (char)(letterIndex + 97);
            sms.Append(currentLetter);
        }

        Console.WriteLine(sms.ToString());
    }
}
