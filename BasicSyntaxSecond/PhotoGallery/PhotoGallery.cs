using System;

public class PhotoGallery
{
    public static void Main()
    {
        int photoNumber = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        double photoSize = double.Parse(Console.ReadLine());
        int photoWidth = int.Parse(Console.ReadLine());
        int photoHeight = int.Parse(Console.ReadLine());
       
        Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
        Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:D2}:{minutes:D2}");

        if (photoSize < 1000)
        {
            Console.WriteLine($"Size: {photoSize}B");
        }
        else if (photoSize < 1000000)
        {
            photoSize /= 1000;
            Console.WriteLine($"Size: {photoSize}KB");
        }
        else
        {
            photoSize /= 1000000;
            Console.WriteLine($"Size: {photoSize}MB");
        }

        string orientation = "";

        if (photoWidth > photoHeight)
        {
            orientation = "landscape";           
        }
        else if (photoWidth < photoHeight)
        {
            orientation = "portrait";         
        }
        else
        {
            orientation = "square";         
        }
      
        Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} ({orientation})");
    }
}
