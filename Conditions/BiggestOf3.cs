using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BiggestOf3
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        double biggestNumber = 0;

        if (firstNumber >= secondNumber && firstNumber>= thirdNumber )
        {
            biggestNumber = firstNumber;
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
        {
            biggestNumber = secondNumber;
        }
        else
        {
            biggestNumber = thirdNumber;
        }

        Console.WriteLine(biggestNumber);
    }
}

