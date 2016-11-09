using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PointInCircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double diagonal = Math.Sqrt((x * x) + (y * y));

        if(diagonal <= 2.00)
        {
            Console.WriteLine("yes" + " " + "{0:0.00}", diagonal);
        }
        else
        {
            Console.WriteLine("no" + " " + "{0:0.00}", diagonal);
        }

    }
}

