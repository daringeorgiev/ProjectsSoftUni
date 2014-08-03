using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Set a:");
        short a = short.Parse(Console.ReadLine());
        Console.WriteLine("Set b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Set c:");
        double c = double.Parse(Console.ReadLine());
        //Binary
        string aBin = Convert.ToString(a, 2);
        int Bin = int.Parse(aBin);
        Console.WriteLine("|{0,-10:X}|{3:D10}|{1,10:F2}|{2,-10:F3}|", a, b, c, Bin);  
    }
}

