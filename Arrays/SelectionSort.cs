using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SelectionSort
{
    static void Swap(int[] array, int a, int b)
    {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] arrayN = new int[size];


        for (int i = 0; i < size; i++)
        {
            arrayN[i] = int.Parse(Console.ReadLine());
        }
        //

        for (int i = 0; i < arrayN.Length - 1; i++)
        {
            //create a minimum element

            //test it against the others
            int iMin = i;
            for (int j = i + 1; j < arrayN.Length; j++)
            {
                if (arrayN[j] < arrayN[iMin])
                {
                    iMin = j;
                }
            }

            if (iMin != i)
            {
                int temp = arrayN[i];
                arrayN[i] = arrayN[iMin];
                arrayN[iMin] = temp;
            }
        }

        foreach (int item in arrayN)
        {
            Console.WriteLine(item);
        }
    }
}


