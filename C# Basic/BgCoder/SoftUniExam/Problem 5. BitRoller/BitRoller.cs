using System;
using System.Collections.Generic;
using System.Collections;

class BitRoller
{
    static void Main()
    {
        //int n = 2521;
        //int f = 8;
        //int r = 4;

        int n = int.Parse(Console.ReadLine());
        //int f = int.Parse(Console.ReadLine());
        //int r = int.Parse(Console.ReadLine());

        BitArray number= ToBinary(n);
        Console.WriteLine(number);
        //if (n==1)
        //{
        //    Console.WriteLine(1);
        //}
        //else
        //{
        //    Console.WriteLine(0);
        //}

        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(19, '0'));

        //Freezen bit
        //int rightNumber = n >> f;
        //bool bitCheck = ((rightNumber & 1) == 1);
        //if (bitCheck)
        //{
        //    byte freezeBit = 1;
        //}
        //else
        //{
        //    byte freezeBit = 0;
        //}



        //Console.WriteLine(bit);
    }

    public static BitArray ToBinary(int numeral)
    {
        BitArray binary = new BitArray(new int[] { numeral });
        bool[] bits = new bool[binary.Count];
        binary.CopyTo(bits, 0);
        return binary;
    }

    //private int getIntFromBitArray(BitArray bitArray)
    //{
    //    int value = 0;

    //    for (int i = 0; i < bitArray.Count; i++)
    //    {
    //        if (bitArray[i])
    //            value += Convert.ToInt16(Math.Pow(2, i));
    //    }

    //    return value;
    //}


}

