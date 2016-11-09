using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Factorial
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double X = double.Parse(Console.ReadLine());


        double factorial = 1;
        double result = 0;
        double sum = 1 ;

        for (int i = 1; i <= N; i++)
        {
            factorial *= i;
            result = factorial / Math.Pow(X, i);
            sum += result;
        }
   
 
        Console.WriteLine("{0:0.00000}",sum);

    }
}

