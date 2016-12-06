using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToBinary
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        long remainder = 0;

        string result = string.Empty;

        while (number > 0)
        {
            remainder = number % 2;
            result = remainder.ToString() + result;
            number = number / 2;

        }
        Console.WriteLine(result);
    }
}