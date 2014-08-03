using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        string format = "d.MM.yyyy";
        Console.WriteLine("Set first date:");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
        Console.WriteLine("Set second date:");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);

        TimeSpan result = secondDate - firstDate;
        Console.WriteLine(result.Days);
    }
}

