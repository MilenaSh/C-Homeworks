using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class HexadecimalToBinary
{
    static void Main()
    {
        string hexadecimal = Console.ReadLine();
        char[] input = hexadecimal.ToCharArray();

        string[] binaryNumbers = new string[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 48)
            {
                binaryNumbers[i] = "0000";
            }
            else if (input[i] == 49)
            {
                binaryNumbers[i] = "0001";
            }
            else if (input[i] == 50)
            {
                binaryNumbers[i] = "0010";
            }
            else if (input[i] == 51)
            {
                binaryNumbers[i] = "0011";
            }
            else if (input[i] == 52)
            {
                binaryNumbers[i] = "0100";
            }
            else if (input[i] == 53)
            {
                binaryNumbers[i] = "0101";
            }
            else if (input[i] == 54)
            {
                binaryNumbers[i] = "0110";
            }
            else if (input[i] == 55)
            {
                binaryNumbers[i] = "0111";
            }
            else if (input[i] == 56)
            {
                binaryNumbers[i] = "1000";
            }
            else if (input[i] == 57)
            {
                binaryNumbers[i] = "1001";
            }
            else if (input[i] == 'A')
            {
                binaryNumbers[i] = "1010";
            }
            else if (input[i] == 'B')
            {
                binaryNumbers[i] = "1011";
            }
            else if (input[i] == 'C')
            {
                binaryNumbers[i] = "1100";
            }
            else if (input[i] == 'D')
            {
                binaryNumbers[i] = "1101";
            }
            else if (input[i] == 'E')
            {
                binaryNumbers[i] = "1110";
            }
            else if (input[i] == 'F')
            {
                binaryNumbers[i] = "1111";
            }
        }

        //removing zeros

        string lastString = string.Join("",binaryNumbers);
        BigInteger intPrint = BigInteger.Parse(lastString);

        Console.WriteLine(intPrint);
    }
}

