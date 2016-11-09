using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Gravity
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());

        double moonWeight = 0.17f * weight;
        double rounded = Math.Round(moonWeight, 3);
        Console.WriteLine(String.Format("{0:00.000}", rounded));
        Console.ReadLine();
    }
}

