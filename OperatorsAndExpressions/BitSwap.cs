using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitSwap
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());


        // Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        int firstBits = 0;

        for (int i = p; i < p + k; i++)
        {
            int mask = 1 << i;
            firstBits = firstBits | (n & mask);
            n = n & ~mask;
        }

        int lastBits = 0;

        for (int i = q; i < q + k; i++)
        {
            int mask = 1 << i;
            lastBits = lastBits | (n & mask);
            n = n & ~mask;
        }

        int distance = q - p;

        firstBits = firstBits << distance;
        lastBits = lastBits >> distance;

        n = n | firstBits | lastBits;

        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(firstBits, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(lastBits, 2).PadLeft(32, '0'));
        Console.WriteLine(n);

    }

}


