using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumIntegers
{
    static void Main()
    {

        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(SumOfIntegers(numbers));

    }

    static int SumOfIntegers(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }


}

