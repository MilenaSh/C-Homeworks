using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CircleRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());


        double centerX = 1;
        double centerY = 1;
        double r = 1.5;

        if ((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY) <= r * r)
        {
            Console.Write ("inside circle" + " ");
        }
        else
        {
            Console.Write ("outside circle" + " ");
        }

        if (x <= 5 && x >= -1 && y <=1 && y >= -1)
        {
            Console.Write("inside rectangle");
        }
        else
        {
            Console.Write("outside rectangle \n");
        }
    }
}

