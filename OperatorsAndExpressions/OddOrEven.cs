﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddOrEven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if(number % 2 == 0)
        {
            Console.WriteLine("even" + " " + number);
        }
        else
        {
            Console.WriteLine("odd" + " " + number);
        }
    }
}

