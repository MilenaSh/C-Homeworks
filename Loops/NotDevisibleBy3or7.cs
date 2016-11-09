using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NotDevisibleBy3or7
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 != 0 && i % 7 !=0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}

