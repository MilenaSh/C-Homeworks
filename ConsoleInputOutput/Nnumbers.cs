using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Nnumbers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double SumOfNumbers = 0;

        for (int i = 1; i <= n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            SumOfNumbers = num + SumOfNumbers;
        }
        Console.WriteLine(SumOfNumbers);
    }
}

