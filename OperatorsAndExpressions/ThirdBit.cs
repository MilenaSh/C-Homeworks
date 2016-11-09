using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ThirdBit
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint mask = 1 << 3;
        uint maskCheck = n & mask;

        uint bit = maskCheck >> 3;

        Console.WriteLine(bit);
    }
}

