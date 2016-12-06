using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargerThanNeighbours
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int result = IsLargerThanNeighbours(inputArray);
        Console.WriteLine(result);
    }

    static int IsLargerThanNeighbours(int[] input)
    {
        int counter = 0;
        for (int i = 1; i < input.Length - 1; i++)
        {
            if (input[i] > input[i - 1] && input[i] > input [i +1 ]  )
            {
                counter += 1;
            }
        }
        return counter;
    }
}

