using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalIntoHex
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        long remainder = 0;

        string result = string.Empty;

        while (number > 0)
        {
            remainder = number % 16;

            if (remainder == 10)
            {
                remainder = "A";
            }
            result = remainder.ToString();
            number = number / 16;

        }
        int a = 188;
        int b = 16;

        int result = a % 16;
        Console.WriteLine(result);
    }
}


