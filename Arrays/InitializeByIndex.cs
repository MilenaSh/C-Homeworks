using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class InitializeByIndex
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());

        int[] myArray = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            myArray[i] = i*5;
            Console.WriteLine(myArray[i]);
        }
    }
}

