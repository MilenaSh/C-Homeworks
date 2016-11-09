using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Circles
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * (r * r);

        Console.Write("{0:00.00} ", perimeter);
        Console.Write("{0:00.00}", area);
        Console.WriteLine();
    }
}

