using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimeCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("false");
        }
        else
        {

            double squareRoot = Math.Sqrt(number);
            bool isPrime = true;

            for (int i = 2; i <= squareRoot; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime.ToString().ToLower());

        }
    }
}
