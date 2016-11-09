using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompareCharArrays
{
    static void Main()
    {
        string array1 = Console.ReadLine();
        string array2 = Console.ReadLine();

        char[] firstArray = array1.ToCharArray();
        char[] secondArray = array2.ToCharArray();

        int length = Math.Min(firstArray.Length, secondArray.Length);
        //compare the arrays char by char
        bool equal = true;

        for (int i = 0; i < length; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                equal = false;
                Console.WriteLine(">");
                break;
            }
            else if (firstArray[i] < secondArray[i])
            {
                equal = false;
                Console.WriteLine("<");
                break;
            }
        }
        if (equal)
        {
            if(firstArray.Length == secondArray.Length)
            {
                Console.WriteLine("=");
            }
            else
            {
            Console.WriteLine(firstArray.Length > secondArray.Length ? ">" : "<");
            }
        }
    }
}

