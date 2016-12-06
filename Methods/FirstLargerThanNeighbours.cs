using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirstLargerThanNeighbours
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int result = FirstLarger(inputArray);
        Console.WriteLine(result);
    }

    static int FirstLarger(int[] input)
    {
        int result = 0;
        for (int i = 1; i < input.Length - 1; i++)
        {
            if (input[i] > input[i - 1] && input[i] > input[i + 1])
            {
                result = i;
                break;
            }

        }

        if (result == 0)
        {
            result = -1;
        }
        return result;
    }
}

