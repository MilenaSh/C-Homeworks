﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreaterNumber
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber>secondNumber)
        {
            Console.WriteLine(secondNumber + " " + firstNumber);
        }
        else
        {
            Console.WriteLine(firstNumber + " " + secondNumber);
        }
    }
}

