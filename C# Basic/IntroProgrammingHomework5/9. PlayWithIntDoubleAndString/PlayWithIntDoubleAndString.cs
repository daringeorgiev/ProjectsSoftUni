using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        byte choise = byte.Parse(Console.ReadLine());
        switch (choise)
        {
            case 1:
                Console.WriteLine("Please enter an int:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine(num1+1);
                break;
            case 2:
                Console.WriteLine("Please enter a double:");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(num2+1);
                break;
            case 3:
                Console.WriteLine("Please enter a string");
                string text = Console.ReadLine();
                Console.WriteLine("{0}*", text);
                break;
            default:
                Console.WriteLine("Wrong choise");
                break;
        }
    }
}

