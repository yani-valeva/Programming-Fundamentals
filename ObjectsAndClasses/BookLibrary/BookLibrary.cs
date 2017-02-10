using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

public class BookLibrary
{
    public static void Main()
    {
        Library library = new Library();
        library.Books = new List<Book>();

        int numberOfBook = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfBook; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            Book book = new Book();
            book.Title = input[0];
            book.Author = input[1];
            book.Publisher = input[2];
            book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.IsbnNumber = input[4];
            book.Price = decimal.Parse(input[5]);
            library.Books.Add(book);
        }

        Dictionary<string, decimal> booksByAuthors = new Dictionary<string, decimal>();

        foreach (var author in library.Books)
        {
            string authorsName = author.Author;
            decimal price = author.Price;

            if (!booksByAuthors.ContainsKey(authorsName))
            {
                booksByAuthors.Add(authorsName, 0m);
            }

            booksByAuthors[authorsName] += price;
        }

        foreach (var author in booksByAuthors.OrderByDescending(p => p.Value).ThenBy(n => n.Key))
        {
            Console.WriteLine($"{author.Key} -> {author.Value:f2}");
        }
    }
}