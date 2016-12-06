using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GetLargestNumber
{
    static int GetMax(int firstNumber, int secondNumber )
    {
        int max = firstNumber;
        if (secondNumber > firstNumber)
        {
            max = secondNumber;
        }
        return max;
    }

    static void Main()
    {

        string input = Console.ReadLine();

        string[] arrayInput = input.Split(' ');

        int firstInteger = int.Parse(arrayInput[0]);
        int secondInteger = int.Parse(arrayInput[1]);
        int thirdInteger = int.Parse(arrayInput[2]);

        int greatest = GetMax(firstInteger, secondInteger);
        int max = GetMax(greatest, thirdInteger);

        Console.WriteLine(max);
    }
}

