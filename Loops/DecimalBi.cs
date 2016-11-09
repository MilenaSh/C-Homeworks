using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class DecimalBi
    {

        static void Main()
        {

            long dec = long.Parse(Console.ReadLine());

            long rest;
            string binary = string.Empty;

            while (dec > 0)
            {
                rest = dec % 2;
                dec /= 2;
                binary = rest.ToString() + binary;
            }

            Console.WriteLine(binary);
        }
    }
}

