using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseNumber
{
    static void Main()
    {
        string number = Console.ReadLine();

       char[] reversed =  ReverseOfNumber(number);

        foreach (var item in reversed)
        {
            Console.Write(item);
        }
    }

    static char[] ReverseOfNumber(string input)
    {
        char[] numberAsArea = input.ToCharArray();
        char[] reversed = new char[input.Length];
        int j = 0;

        for (int i = numberAsArea.Length -1 ; i >= 0; i--)
        {
            reversed[j] = numberAsArea[i];
            j++;
        }

        return reversed;
    }
}

