using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AreaBySides
{
    static void Main()
    {
        double sideOne = double.Parse(Console.ReadLine());
        double sideTwo = double.Parse(Console.ReadLine());
        double sideThree = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:F2}", GetArea(sideOne, sideTwo, sideThree));

    }

    static double GetArea(double a, double b, double c)
    {
        double param = (a + b + c) / 2;
        double result = Math.Sqrt(param*(param - a)*(param - b)*(param - c));

        return result;
    }
}

