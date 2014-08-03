using System;

class Program
{
    static void Main()
    {
        int startHH = int.Parse(Console.ReadLine());
        int startMM = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int examHH = int.Parse(Console.ReadLine());
        int examMM = int.Parse(Console.ReadLine());

        int finalMM=0;
        int finalHH=0;
        string finalPD=partOfDay;

        if ((startMM + examMM) >= 60)
        {
            finalHH++;
            finalMM = startMM + examMM - 60;
        }
        else
        {
            finalMM = startMM + examMM;
        }
        finalHH += startHH + examHH;
        while (finalHH >12)
        {
            if (finalPD == "PM")
            {
                finalPD = "AM";
            }
            else
            {
                finalPD = "PM";
            }
            finalHH = finalHH - 12;
        }


        //Print
        if (finalHH==12)
        {
            if(finalPD=="AM")
            {
                finalPD="PM";
            }
            else
            {
                finalPD = "AM";
            }
        }

        if (finalHH<10)
        {
            Console.Write("0");
        }
        Console.Write(finalHH + ":");
        if (finalMM < 10)
        {
            Console.Write("0");
        }
        Console.Write(finalMM + ":");
        Console.WriteLine(finalPD);
        //Console.WriteLine("{0}:{1}:{2}", finalHH, finalMM, finalPD);
    }
}

