using System;

class Greetings
{
    public static void Main()
    {
        string name = Console.ReadLine();
        PrintGreetingsByName(name);
    }

    public static void PrintGreetingsByName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}
