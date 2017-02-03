using System;
using System.Collections.Generic;

public class PhonebookUpgrade
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

        while (!input[0].Equals("END"))
        {
            if (input[0].Equals("A"))
            {
                phonebook[input[1]] = input[2];
            }
            else if (input[0].Equals("S"))
            {
                PrintSearchingContact(input, phonebook);
            }
            else if (input[0].Equals("ListAll"))
            {
                foreach (var contact in phonebook)
                {
                    Console.WriteLine($"{contact.Key} -> {contact.Value}");
                }
            }

            input = Console.ReadLine().Split(' ');
        }
    }

    public static void PrintSearchingContact(string[] input, SortedDictionary<string, string> phonebook)
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
}
