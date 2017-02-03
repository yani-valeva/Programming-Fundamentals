using System;
using System.Collections.Generic;

public class Phonebook
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        while (!input[0].Equals("END"))
        {
            if (input[0].Equals("A"))
            {
                AddContactInPhonebook(input, phonebook);
            }
            else if (input[0].Equals("S"))
            {
                PrintSearchingContact(input, phonebook);
            }

            input = Console.ReadLine().Split(' ');
        }
    }

    public static void PrintSearchingContact(string[] input, Dictionary<string, string> phonebook)
    {
        if (phonebook.ContainsKey(input[1]))
        {
            Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
        }
        else
        {
            Console.WriteLine($"Contact {input[1]} does not exist.");
        }
    }

    public static void AddContactInPhonebook(string[] input, Dictionary<string, string> phonebook)
    {
        if (!phonebook.ContainsKey(input[1]))
        {
            phonebook.Add(input[1], null);
        }

        phonebook[input[1]] = input[2];
    }
}
