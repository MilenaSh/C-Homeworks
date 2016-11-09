using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        System.Numerics.BigInteger factorialN = 1;
        System.Numerics.BigInteger factorialNDouble = 1;
       
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i; 

        }

        for (int i = 1; i <= 2*n; i++)
        {
            factorialNDouble *= i;
        }

        int result1 = (n + 1);
        System.Numerics.BigInteger result2 = (factorialNDouble / (factorialN*factorialN));
        System.Numerics.BigInteger resultFinal = result2 / (System.Numerics.BigInteger)result1;

        Console.WriteLine(resultFinal);
        
    }
}

