using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        bool leap = DateTime.IsLeapYear(year);

        if (leap == true)
        {
            Console.WriteLine("Leap");
        }
        else
        {
            Console.WriteLine("Common");
        }

    }
    
}
