using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AreaBySidesAndAngle
{
    static void Main()
    {
        double sideOne = double.Parse(Console.ReadLine());
        double sideTwo = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:F2}", CalculateArea(sideOne, sideTwo, angle));
    }

    static double CalculateArea(double firstSide, double secondSide, double angle)
    {
        double sin = (Math.Sin(angle * (Math.PI / 180.0)));
        double result = (firstSide * secondSide * sin) / 2;

        return result;
    }
}

