using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimslToHexadecimal
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        long remainder = 0;
        string divisionResult = "";

        List<string> finalResult = new List<string>();

        string result = string.Empty;

        while (number > 0)
        {
            remainder = number % 16;

            if (remainder == 10)
            {
                divisionResult = "A";
            }
            else if (remainder == 11)
            {
                divisionResult = "B";
            }
            else if (remainder == 12)
            {
                divisionResult = "C";
            }
            else if (remainder == 13)
            {
                divisionResult = "D";
            }
            else if (remainder == 14)
            {
                divisionResult = "E";
            }
            else if (remainder == 15)
            {
                divisionResult = "F";
            }
            else
            {
                divisionResult = remainder.ToString();
            }

            finalResult.Add(divisionResult);
            number = number / 16;

        }

        for (int i = finalResult.Count - 1; i >= 0; i--)
        {
            Console.Write(finalResult[i]);
        }
        Console.WriteLine();

  
    }
}
