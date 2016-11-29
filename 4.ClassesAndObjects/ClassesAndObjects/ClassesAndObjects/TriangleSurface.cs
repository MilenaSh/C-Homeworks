using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TriangleSurface
{
    static void Main()
    {
        double length = double.Parse(Console.ReadLine());
        double altitude = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:F2}",GetSurface(length, altitude));

    }

    static double GetSurface(double a, double h)
    {
        double result = (a * h) / 2;
        return result;
    }
}


