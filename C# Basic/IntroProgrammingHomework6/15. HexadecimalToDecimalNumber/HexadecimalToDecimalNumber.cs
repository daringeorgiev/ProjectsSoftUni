using System;

    class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter hecadecimal number:");
        string number = Console.ReadLine();
        char[] num = number.ToCharArray();
        long sum = 0;
        int j = 0;//Index for Math.Pow;
        for (int i = (num.Length-1); i >-1; i--)
        {
            
            switch (num[i])
            {
                case '0':
                    break;
                case '1':
                    sum += 1 * Convert.ToInt64(Math.Pow(16, j));
                    break;
                case '2':
                    sum += 2 * Convert.ToInt64(Math.Pow(16, j));
                    break;
                case '3':
                    sum += 3 * Convert.ToInt64(Math.Pow(16, j));
                    break;
                case '4':
                    sum += 4 * Convert.ToInt64(Math.Pow(16, j));
                    break;
                case '5':
                    sum += 5 * Convert.ToInt64(Math.Pow(16, j));
                    break;
                case '6':
                    sum += 6 * Convert.ToInt64(Math.Pow(16, j));
                    break;
                case '7':
                    sum += 7 * Convert.ToInt64(Math.Pow(16, j));
                    break;
                case '8':
                    sum += 8 * Convert.ToInt64(Math.Pow(16, j));
                    break;
                case '9':
                    sum += 9 * Convert.ToInt64(Math.Pow(16, j));
                    break;
                case 'A':
                case 'a':
                    sum += 10 * Convert.ToInt64(Math.Pow(16, j));
                    break;
                case 'B':
                case 'b':
                    sum += 11 * Convert.ToInt64(Math.Pow(16, j));
                    break;
                case 'C':
                case 'c':
                    sum += 12 * Convert.ToInt64(Math.Pow(16, j));
                    break;
                case 'D':
                case 'd':
                    sum += 13 * Convert.ToInt64(Math.Pow(16, j));
                    break;
                case 'E':
                case 'e':
                    sum += 14 * Convert.ToInt64(Math.Pow(16, j));
                    break;
                case 'F':
                case 'f':
                    sum += 15 * Convert.ToInt64(Math.Pow(16, j));
                    break;
               default:
                    Console.WriteLine("Invalide number");
                    break;
            }
            j++;
        }
        Console.WriteLine("Decimal is: {0}", sum);
    }
}

