using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaximalSequence
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int counterMax = 0;
        int counter = 1;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                counter++;
            }
            if (counter > counterMax)
            {
                counterMax = counter;
            }
            if (array[i] != array[i + 1])
            {
                counter = 1;
            }
            
        }

        if (size==1)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine(counterMax);
        }
        
    }


}



