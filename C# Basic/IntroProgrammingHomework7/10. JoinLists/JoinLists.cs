using System;
using System.Collections.Generic;

class JoinLists
{
    static void Main()
    {
        string[] firstNums = Console.ReadLine().Split(' ');
        string[] secondNums = Console.ReadLine().Split(' ');

        List<string> Nums = new List<string>();    //list for new item
    
        //Add nums from firstNumst ot the list
        for (int i = 0; i < firstNums.Length; i++)
        {
            Nums.Add(firstNums[i]);
        }

        //Add nums from secondNums, which is not similar
        for (int i = 0; i < secondNums.Length; i++)
        {
             Nums.Add(secondNums[i]);
        }

        //Remove duplicates
        List<string> results = NoDublicates(Nums);

        //Print
        foreach (var num in results)
        {
            Console.Write(num + " ");
        }

        //New line
        Console.WriteLine();
    }

    private static List<string> NoDublicates(List<string> Nums)
    {
        //Sort
        Nums.Sort();
        
        //Loop 
        int index = 0;
        while (index<(Nums.Count-1))
        {
            if (Nums[index]==Nums[index+1])
            {
                Nums.RemoveAt(index);
            }
            else
            {
                index++;
            }
        }
        //Result
        return Nums;      
    }
}

