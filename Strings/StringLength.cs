using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input.Length < 20)
        {
            string result = input.PadRight(20, '*');
            Console.WriteLine(result);
        }
        else
        {
            string result = input;
            Console.WriteLine(result);
        }

        
    }
}

