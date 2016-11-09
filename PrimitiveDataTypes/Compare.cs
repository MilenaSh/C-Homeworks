using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Compare
{
    static void Main()
    {
       double a = double.Parse(Console.ReadLine());
       double b = double.Parse(Console.ReadLine());
        
            Console.WriteLine(Math.Abs(a - b) < 0.000001);
        Console.ReadLine();
    }
}

