using System;
using System.Collections.Generic;

class OddEvenElements
{
    static void Main()
    {
        string[] num = Console.ReadLine().Split(' ');
        if (num.Length>=1)
        {


            //Set Vars
            decimal oddSum = 0m;
            decimal oddMin = decimal.Parse(num[0]);
            decimal oddMax = decimal.Parse(num[0]);
            if (num.Length==1)
            {
                oddSum = decimal.Parse(num[0]);
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", oddSum.ToString("0.#####"), oddMin.ToString("0.#####"), oddMax.ToString("0.#####"));
            }
            else
            {
                decimal evenSum = 0m;
                decimal evenMin = decimal.Parse(num[1]);
                decimal evenMax = decimal.Parse(num[1]);
                decimal temp;

                bool evenCheck = false;
                bool oddCheck = false;

                for (int i = 0; i < num.Length; i++)
                {
                    temp = decimal.Parse(num[i]);
                    //temp = double.Parse(num[i]);
                    if (i % 2 == 0)
                    {
                        oddCheck = true;
                        oddSum += temp;
                        if (temp < oddMin)
                        {
                            oddMin = temp;
                        }
                        if (temp > oddMax)
                        {
                            oddMax = temp;
                        }
                    }
                    else //if (i % 2 != 0)
                    {
                        evenCheck = true;
                        evenSum += temp;
                        if (temp < evenMin)
                        {
                            evenMin = temp;
                        }
                        if (temp > evenMax)
                        {
                            evenMax = temp;
                        }
                    }
                }


                if (oddCheck == false)
                {
                    Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
                }
                else if (evenCheck == false)
                //if (evenCheck == false)
                {
                    Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", oddSum.ToString("0.#####"), oddMin.ToString("0.#####"), oddMax.ToString("0.#####"));
                }
                else
                {
                    Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", oddSum.ToString("0.#####"), oddMin.ToString("0.#####"), oddMax.ToString("0.#####"), evenSum.ToString("0.#####"), evenMin.ToString("0.#####"), evenMax.ToString("0.#####"));
                }
            }
        }
        //else if (num.Length==1)
        //{
        //    Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum=No, EvenMin=No, EvenMax=No", num[0]);
        //}
        else
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
    }
}

