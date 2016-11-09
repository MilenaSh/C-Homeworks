using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Rectangular
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            double perimeter = 2*width + 2*height;

            Console.WriteLine(String.Format("{0:0.00} {1:0.00}", area, perimeter));

        }

    }
}
