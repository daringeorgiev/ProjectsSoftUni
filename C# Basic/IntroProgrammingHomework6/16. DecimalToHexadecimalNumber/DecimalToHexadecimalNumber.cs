using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        //Set n
        Console.WriteLine("Please enter n:");
        long n = long.Parse(Console.ReadLine());
        //Var
        bool result = true;
        string binar = "";
        //Loop to divide n by 2
        while (result)
        {
            switch (n%16)
            {   
                case 0:
                    binar += "0";
                    break;
                case 1:
                    binar += "1";
                    break;
                case 2:
                    binar += "2";
                    break;
                case 3:
                    binar += "3";
                    break;
                case 4:
                    binar += "4";
                    break;
                case 5:
                    binar += "5";
                    break;
                case 6:
                    binar += "6";
                    break;
                case 7:
                    binar += "7";
                    break;
                case 8:
                    binar += "8";
                    break;
                case 9:
                    binar += "9";
                    break;
                case 10:
                    binar += "A";
                    break;
                case 11:
                    binar += "B";
                    break;
                case 12:
                    binar += "C";
                    break;
                case 13:
                    binar += "D";
                    break;
                case 14:
                    binar += "E";
                    break;
                case 15:
                    binar += "F";
                    break;
                default:
                    Console.WriteLine("Erorr");
                    break;
            }
            n = n / 16;
            if (n == 0)
            {
                result = false;
            }
        }
        //Reverse string
        char[] binarReversed = binar.ToCharArray();
        for (int i = binarReversed.Length; i > 0; --i)
        {
            Console.Write(binarReversed[i - 1]);
            //Last Writeline
            if (i == 1)
            {
                Console.WriteLine();
            }
        }
    }
}

