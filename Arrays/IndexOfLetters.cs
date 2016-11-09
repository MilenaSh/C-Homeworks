using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IndexOfLetters
{
    static void Main()
    {
        string word = Console.ReadLine();
       char[] array = word.ToCharArray();

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i] -97);
        }

    }
}

