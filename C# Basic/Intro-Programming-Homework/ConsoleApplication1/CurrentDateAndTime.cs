using System;

class CurrentDateAndTime
{
   
    static void Main()
    {
        // Write the current date and time.

        string now = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        Console.WriteLine(now);
    }
}