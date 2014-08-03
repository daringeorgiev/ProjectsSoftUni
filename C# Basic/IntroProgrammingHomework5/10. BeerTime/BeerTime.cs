using System;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Set time:");
        DateTime time;
        if (DateTime.TryParse(Console.ReadLine(), out time))
        {
            DateTime start = DateTime.Parse("1:00 PM");
            DateTime end = DateTime.Parse("3:00 AM");
            if (time >= start || time <= end)
            {
                Console.WriteLine("Beer time");
            }
            else
            {
                Console.WriteLine("Not-beer time");
            }
        }
        else
        {
            Console.WriteLine("Invalid time");
        }
    }
}

