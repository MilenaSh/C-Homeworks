using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FiveAndSeven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine((number % 35 == 0).ToString().ToLower() + " " + number);
    }
}

