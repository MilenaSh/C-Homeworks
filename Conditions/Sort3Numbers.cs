using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sort3Numbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int biggest = int.MinValue;
        int middle = int.MinValue;
        int lowest = int.MinValue;

        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            biggest = firstNumber;
            if (secondNumber > thirdNumber)
            {
                middle = secondNumber;
                lowest = thirdNumber;
            }
            else
            {
                middle = thirdNumber;
                lowest = secondNumber;
            }
        }

        if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
        {
            biggest = secondNumber;
            if (firstNumber > thirdNumber)
            {
                middle = firstNumber;
                lowest = thirdNumber;
            }
            else
            {
                middle = thirdNumber;
                lowest = firstNumber;
            }
        }

        if (thirdNumber >= firstNumber && thirdNumber >= secondNumber)
        {
            biggest = thirdNumber;
            if (firstNumber > secondNumber)
            {
                middle = firstNumber;
                lowest = secondNumber;
            }
            else
            {
                middle = secondNumber;
                lowest = firstNumber;
            }
        }

        Console.WriteLine(biggest + " " + middle + " " + lowest);
    }
}



