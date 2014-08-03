using System;

class AgesAfter10Years
{
    static void Main()
    {
        //Old version

        //Console.Write("Set your ages:");
        //byte ages = byte.Parse(Console.ReadLine());
        //Console.WriteLine("You will be {0} years old after 10 year",(ages+10));

        //New version
        Console.WriteLine("Set your birth year:");
        int BirthYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Set your birth month:");
        int BirthMonth = int.Parse(Console.ReadLine());
        Console.WriteLine("Set your birth day:");
        int BirthDay = int.Parse(Console.ReadLine());

        int NowYear = DateTime.Now.Year;
        int NowMonth = DateTime.Now.Month;
        int NowDay = DateTime.Now.Day;
        
        int ages = NowYear - BirthYear;
        if (BirthMonth==NowMonth)
        {
            if ( BirthDay >= NowDay)
            {
                ages = --ages;
            }
        }
        else if (BirthMonth > NowMonth) 
        {
            ages = --ages;
        }

        Console.WriteLine("After 10 year you will be {0} years old.",(ages+10));
    }
}

