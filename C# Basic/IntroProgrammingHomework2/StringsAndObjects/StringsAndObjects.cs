using System;

class StringsAndObjects
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";
        object all = a + " " + b;
        string c = (string)all;
        Console.WriteLine(c);
    }
}
