using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class HexadecimalToDecimal
{
    static void Main()
    {
        string hexadecimal = Console.ReadLine();
        char[] input = hexadecimal.ToCharArray();

        BigInteger result1 = 0;
        BigInteger finalResult = 0;
        BigInteger letterResult = 0;
        long j = 0;

        

        for (int i = input.Length - 1; i >= 0; i--)
        {
            result1 = (BigInteger)Math.Pow(16, i);

            if (input[j] >= 65 && input[j] <= 70)
            {
                letterResult = 10 + (int)(input[j] - 65);
                finalResult += result1 * letterResult;
            }
            else
            {
                finalResult += result1 * (int)(input[j] - 48);
            }
            j++;
        }

        Console.WriteLine(finalResult);
    }
}

