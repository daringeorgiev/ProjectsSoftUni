using System;

class PeaceOfCake
{
    static void Main()
    {

        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long d = long.Parse(Console.ReadLine());

        if (b == 0 || d == 0)
        {
            Console.WriteLine("error");
        }
        else
        {


            long fraction1 = ((a * d) + (c * b));
            long fraction2 = b * d;
            if (fraction1 / fraction2 >= 1)
            {
                Console.WriteLine(fraction1 / fraction2);
            }
            else
            {
                decimal cakes = fraction1 / Convert.ToDecimal(fraction2);
                Console.WriteLine("{0:f22}", cakes);
            }

            Console.WriteLine(fraction1 + "/" + fraction2);
        }    
     }
}
