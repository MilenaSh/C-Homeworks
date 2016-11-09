using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumbersToN
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.Write(i + " ");
        }
    }
}


