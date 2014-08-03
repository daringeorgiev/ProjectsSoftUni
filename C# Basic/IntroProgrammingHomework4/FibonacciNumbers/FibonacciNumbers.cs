using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            Console.WriteLine("Set n:");
            int n = int.Parse(Console.ReadLine());
   
            if (n == 1)
            {
                Console.WriteLine("0");
            }
            else if (n==2)
            {
                Console.WriteLine("0 \n1");
            }
            else if (n > 2)
            {
                int[] fib = new int[n];
                fib[0] = 0;
                fib[1] = 1;
                fib[2] = 1;

                for (int i = 3; i < n; i++)
                {
                    fib[i] = fib[(i - 1)] + fib[(i - 2)];
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("#{0}-->{1}", (i+1),fib[i]);
                }
            }
            else 
            {
                Console.WriteLine("Error n");
            }
        }
    }

