using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BiggestOf5
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double fourthNumber = double.Parse(Console.ReadLine());
        double fifthNumber = double.Parse(Console.ReadLine());

        double biggestNumber = 0;

        if (firstNumber >= secondNumber)
        {
            biggestNumber = firstNumber;
        }
        else
        {
            biggestNumber = secondNumber;
        }
        if (thirdNumber >= biggestNumber )
        {
            biggestNumber = thirdNumber;
        }
        if (fourthNumber >= biggestNumber)
        {
            biggestNumber = fourthNumber;
        }
        if (fifthNumber >= biggestNumber)
        {
            biggestNumber = fifthNumber;
        }

        Console.WriteLine(biggestNumber);
    }
}

