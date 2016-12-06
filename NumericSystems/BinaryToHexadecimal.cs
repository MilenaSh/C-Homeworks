using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class BinaryToHexadecimal
{
    
    static void Main()
    {
        string input = Console.ReadLine();

        string binaryInput = input.PadLeft(32, '0');

        char[] binaryNumbers = binaryInput.ToCharArray();

        List<string> finalResult = new List<string>();
        // int j = 0;

        string realValue;

        for (int i = 0; i < binaryNumbers.Length; i += 4)
        {
            BigInteger fourBits = 0;
            
            fourBits += (BigInteger)(binaryNumbers[i] - 48) * (BigInteger)Math.Pow(2, 3);
            fourBits += (BigInteger)(binaryNumbers[i +1] - 48) * (BigInteger)Math.Pow(2, 2);
            fourBits += (BigInteger)(binaryNumbers[i + 2] - 48) * (BigInteger)Math.Pow(2, 1);
            fourBits += (BigInteger)(binaryNumbers[i + 3] - 48) * (BigInteger)Math.Pow(2, 0);

            if (fourBits == 10)
            {
                realValue = "A";
            }
            else if (fourBits == 11)
            {
                realValue = "B";
            }
            else if (fourBits == 12)
            {
                realValue = "C";
            }
            else if (fourBits == 13)
            {
                realValue = "D";
            }
            else if (fourBits == 14)
            {
                realValue = "E";
            }
            else if (fourBits == 15)
            {
                realValue = "F";
            }
            else
            {
                realValue = Convert.ToString(fourBits);
            }

            finalResult.Add(realValue);
         
        }

        for (int i = 0; i < finalResult.Count; )
        {
            if (finalResult[i] == "0")
            {
                finalResult.RemoveAt(i);
            }
            else
            {
                break;
            }
        }

        foreach (var item in finalResult)
        {
            Console.Write(item);
        }

        Console.WriteLine();
       
    }
}

