using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TwoFactorials
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        System.Numerics.BigInteger factorialN = 1;
        System.Numerics.BigInteger factorialK = 1;

        //1 < K < N < 100

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;

            if (i <= k)
            {
                factorialK *= i;
            }

        }

        System.Numerics.BigInteger result = factorialN / factorialK;
        Console.WriteLine(result);
    }
}

