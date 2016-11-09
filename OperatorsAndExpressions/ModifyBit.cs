using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ModifyBit
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());


        //sets to 1
        ulong mask = (ulong)1 << p;
        ulong result1 = n | mask;

        //sets to 0
        ulong mask2 = ~((ulong)1 << p);
        ulong result2 = n & mask2;

        if (v == 0)
        {
            Console.WriteLine(result2);
        }
        else
        {
            Console.WriteLine(result1);
        }

    }
}

