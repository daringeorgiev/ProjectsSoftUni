using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("Set char:");
        string card = Console.ReadLine();
        if (card=="J" || card=="Q" || card=="K" || card=="A" )
        {
            Console.WriteLine("YES");
        }
        else 
        {
            int num;
            bool result = int.TryParse(card, out num);
            if (result && num>=2 && num<=10)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

