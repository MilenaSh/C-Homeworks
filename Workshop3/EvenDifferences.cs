using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class EvenDifferences
{
    static void Main()
    {
        //read from console

        string inputInitial = Console.ReadLine();
        string[] input = inputInitial.Split(' ');


        BigInteger sum = 0;
        for (int i = 1; i < input.Length; i++)
        {
            //absolut difference
            long absolute = Math.Abs(long.Parse(input[i]) - (long.Parse(input[i - 1])));
            if (absolute % 2 == 0)
            {
                i += 1;
                sum += absolute;
            }
        }

        Console.WriteLine(sum);


    }
}

