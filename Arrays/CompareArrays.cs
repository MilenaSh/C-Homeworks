using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompareArrays
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int[] array1 = new int[size];
        int[] array2 = new int[size];

        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }

        //compare

        bool areEqual = true;

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                areEqual = false;
            }
        }

        //print result

        if (areEqual == true)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }


    }
}

