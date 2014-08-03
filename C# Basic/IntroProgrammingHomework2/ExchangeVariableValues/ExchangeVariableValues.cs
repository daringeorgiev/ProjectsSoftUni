using System;

class ExchangeVariableValues
{
    static void Main()
    {
        //Before
        int a = 5;
        int b = 10;
        Console.WriteLine("Before: a={0} and b={1}", a, b);        
        //After
        a = a * b;
        b = a / b;
        a = a / b;
        Console.WriteLine("After: a={0} and b={1}", a, b);
    }
}

