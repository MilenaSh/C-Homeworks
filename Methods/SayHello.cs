﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SayHello
{
    static void PrintName()
    {
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        PrintName();
    }
}

