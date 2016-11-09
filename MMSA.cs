using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MMSA
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());

        double min = double.MaxValue;
        double max = double.MinValue;
        double sum = 0;

        for (int i = 0; i < number; i++)
        {
            double input = double.Parse(Console.ReadLine());

            if (input < min)
            {
                min = input;
            }
            if (input > max)
            {
                max = input;
            }

            sum += input;

        }

        Console.WriteLine("min=" + "{0:0.00}", min);
        Console.WriteLine("max=" + "{0:0.00}", max);
        Console.WriteLine("sum=" + "{0:0.00}", sum);
        Console.WriteLine("avg=" + "{0:0.00}", sum / number);


    }
}

