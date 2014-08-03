using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string[] Names = Console.ReadLine().Split(' ');
        string[] remNames = Console.ReadLine().Split(' ');

        bool check=true; 
        List<string> finalNames = new List<string>();
        

        for (int i = 0; i < Names.Length; i++)
        {
            check=true;
            //Check for similar names
            for (int j = 0; j < remNames.Length; j++)
            {
                if (Names[i]==remNames[j])
                {
                   check=false;
                }
            }

            //Add to finalNames
            if (check)
	        {
		        finalNames.Add(Names[i]);
	        }
        }

        //Print
        foreach (var name in finalNames)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}

