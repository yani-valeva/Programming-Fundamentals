using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class BookLibraryModification
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

        string dateAsString = Console.ReadLine();
        DateTime startDate = DateTime.ParseExact(dateAsString, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Dictionary<string, DateTime> booksAndReleasedDates = new Dictionary<string, DateTime>();

        foreach (var book in library.Books)
        {
            string title = book.Title;
            DateTime date = book.ReleaseDate;

            if (!booksAndReleasedDates.ContainsKey(title) && date > startDate)
            {
                booksAndReleasedDates.Add(title, date);
            }
        }

        foreach (var book in booksAndReleasedDates.OrderBy(d => d.Value).ThenBy(t => t.Key))
        {
            string bookTitle = book.Key;
            var date = book.Value.ToString("dd.MM.yyyy");
           
            Console.WriteLine($"{bookTitle} -> {date}");
        }
    }
}