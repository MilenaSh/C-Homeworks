using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SevenCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int number1 = number / 100;
        int number2 = number1 % 10;


        if (number2 == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false" + " " + number2);
        }
    }
}

