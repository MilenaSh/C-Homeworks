using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - (4 * a * c);

        if (discriminant < 0)
        {
            Console.WriteLine("no real roots");

        }
        else if (discriminant == 0)
        {
            Console.WriteLine("{0:0.00}", -(b / (2 * a)));
        }
        else
        {
            double solution1 = (-b + Math.Sqrt(b * b - (4 * a * c))) / (2 * a);
            double solution2 = (-b - Math.Sqrt(b * b - (4 * a * c))) / (2 * a);

            if (solution1 < solution2)
            {
                Console.WriteLine("{0:0.00}", solution1);
                Console.WriteLine("{0:0.00}", solution2);
            }
            else
            {
                Console.WriteLine("{0:0.00}", solution2);
                Console.WriteLine("{0:0.00}", solution1);
            }
        }
    }


}


