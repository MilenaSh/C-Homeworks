using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryIntoDecimal
{
    static void Main()
    {
        string number = Console.ReadLine();

        char[] charArray = number.ToCharArray();
        long sum = 0;

        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            if (charArray[charArray.Length - i - 1] == '1')
            {
                long result = (long)Math.Pow(2, i);
                sum += result;
            }
        }

        Console.WriteLine(sum);

    }
}

