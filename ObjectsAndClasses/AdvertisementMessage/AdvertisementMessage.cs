using System;

public class AdvertisementMessage
{
    public static void Main()
    {
        int numberOfmessages = int.Parse(Console.ReadLine());

        string[] phrases =
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };
        string[] events =
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles.I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };
        string[] authors =
        {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva"
        };
        string[] cities =
        {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };

        Random rnd = new Random();

        for (int count = 0; count < numberOfmessages; count++)
        {

            int currentPhrase = rnd.Next(0, phrases.Length);
            int currentEvent = rnd.Next(0, events.Length);
            int currentAuthor = rnd.Next(0, authors.Length);
            int currentCity = rnd.Next(0, cities.Length);

            Console.WriteLine($"{phrases[currentPhrase]} {events[currentEvent]} {authors[currentAuthor]} - {cities[currentCity]}");
        }
    }
}