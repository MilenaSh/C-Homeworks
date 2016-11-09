using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreatestSum
{
    static void Main()
    {
        //read from console
        int size = int.Parse(Console.ReadLine());
        int numbersCount = int.Parse(Console.ReadLine());

        int[] arrayN = new int[size];
        int[] arraySum = new int[numbersCount];


        for (int i = 0; i < size; i++)
        {
            arrayN[i] = int.Parse(Console.ReadLine());
        }

        //select greatest numbers

        int greatestNumber = 0;
        long sum = 0;
        int position = 0;

        for (int i = 0; i < arraySum.Length; i++)
        {
            for (int j = 0; j < arrayN.Length; j++)
            {
                if (arrayN[j] >= greatestNumber)
                {
                    greatestNumber = arrayN[j];
                    position = j;
                }
                
            }
            arrayN[position] = 0;
            sum += greatestNumber;
            greatestNumber = 0;      
        }

        Console.WriteLine(sum);

    }

}



