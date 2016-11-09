using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NthBit
{
    static void Main()
    {
        long p = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
  
        long mask = 1 << n;
        long maskCheck = p & mask;

        long bit = maskCheck >> n;

        Console.WriteLine(bit);
    }
}

