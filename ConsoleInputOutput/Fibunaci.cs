using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Fibunaci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long num1 = 0;
        long num2 = 1;
        long sum = 1;

        Console.Write(num1);

        if (n != 1)
        {
            Console.Write(", " + num2);
            if (n > 2)
            {
                Console.Write(", ");
            }
            for (int i = 2; i < n; i++)
            {
                sum = num1 + num2;
                Console.Write(sum);
                num1 = num2;
                num2 = sum;
                if (i != n - 1)
                {
                    Console.Write(", ");
                }

            }
            Console.ReadLine();
        }

    }
}


