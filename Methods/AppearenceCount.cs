using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AppearenceCount
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int number = int.Parse(Console.ReadLine());

        int result = ReturnAppearence(inputArray, number);
        Console.WriteLine(result);

    }

    static int ReturnAppearence(int[] input, int numberToCount)
    {
        int counter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == numberToCount)
            {
                counter += 1;
            }

        }
        return counter;
    }
}

