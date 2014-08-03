using System;

class ComparingFloats
{
    static void Main()
    {
        //Set numbers
        Console.WriteLine("Set number1:");
        double number1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Set number2:");
        double number2 = double.Parse(Console.ReadLine());
        
        //Compare numbers
        if (Math.Abs(number1-number2)<0.000001)
        {
            Console.WriteLine("Equal -> True");
        }
        else
        {
            Console.WriteLine("Equal -> False");
        }
    }
}

