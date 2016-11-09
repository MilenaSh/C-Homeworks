using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MostFrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int counter = 0;
        int number = arr[0];
        int finalNumber = arr[0];
        int maxCount = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            number = arr[i];
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == number)
                {
                    counter += 1;
                }
            }
            if (maxCount < counter)
            {
                maxCount = counter;
                finalNumber = number;
            }
            counter = 0;

        }

        Console.WriteLine(finalNumber + " ("+maxCount+" times)");

    }
}

