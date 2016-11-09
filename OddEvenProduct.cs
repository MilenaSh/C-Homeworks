using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddEvenProduct
{
    static void Main()
    {
        int numberDigits = int.Parse(Console.ReadLine());
        string digits = Console.ReadLine();

        int[] arrayDigits = digits.Split(' ').Select(int.Parse).ToArray(); // split per white spaces

        long evenNumbers = 1;
        long oddNumbers = 1;

        for (int i = 0; i < arrayDigits.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers *= arrayDigits[i];
            }
            else if (i % 2 == 1)
            {
                oddNumbers *= arrayDigits[i];
            }
        }

        bool check = evenNumbers == oddNumbers;

        if (check == true)
        {
            Console.WriteLine("yes" + " " + evenNumbers);
        }
        else
        {
            Console.WriteLine("no" + " " + evenNumbers + " " + oddNumbers);
        }

    }
}

