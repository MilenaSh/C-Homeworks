using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Message
{
    static void Main(string[] args)
    {
        //read from Console

        string input1 = Console.ReadLine();

        char[] input1Array = input1.ToCharArray();

        string operation = Console.ReadLine();
        string input2 = Console.ReadLine();

        char[] input2Array = input2.ToCharArray();

        string[] result1 = new string[input1.Length/3];
        string[] result2 = new string[input2.Length / 3];

        //string[] finalResult1 = new string [input1.Length/3];
        //string[] finalResult2 = new string [input2.Length/3];

        int j = 0;

        for (int i = 0; i < input1.Length; i+=3)
        {
            
            if (input1[i] == 'c' && input1[i +1] == 'a' && input1[i + 2] == 'd')
            {
                result1[j] = "0";
            }
            else if (input1[i] == 'x' && input1[i + 1] == 'o' && input1[i + 2] == 'z')
            {
                result1[j] = "1";
            }
            else if (input1[i] == 'n' && input1[i + 1] == 'o' && input1[i + 2] == 'p')
            {
                result1[j] = "2";
            }
            else if (input1[i] == 'c' && input1[i + 1] == 'y' && input1[i + 2] == 'k')
            {
                result1[j] = "3";
            }
            else if (input1[i] == 'm' && input1[i + 1] == 'i' && input1[i + 2] == 'n')
            {
                result1[j] = "4";
            }
            else if (input1[i] == 'm' && input1[i + 1] == 'a' && input1[i + 2] == 'r')
            {
                result1[j] = "5";
            }
            else if (input1[i] == 'k' && input1[i + 1] == 'o' && input1[i + 2] == 'n')
            {
                result1[j] = "6";
            }
            else if (input1[i] == 'i' && input1[i + 1] == 'v' && input1[i + 2] == 'a')
            {
                result1[j] = "7";
            }
            else if (input1[i] == 'o' && input1[i + 1] == 'g' && input1[i + 2] == 'i')
            {
                result1[j] = "8";
            }
            else if (input1[i] == 'y' && input1[i + 1] == 'a' && input1[i + 2] == 'n')
            {
                result1[j] = "9";
            }

            j++;           
        }

        int z = 0;

        for (int i = 0; i < input2.Length; i += 3)
        {
            
            if (input2[i] == 'c' && input2[i + 1] == 'a' && input2[i + 2] == 'd')
            {
                result2[z] = "0";
            }
            else if (input2[i] == 'x' && input2[i + 1] == 'o' && input2[i + 2] == 'z')
            {
                result2[z] = "1";
            }
            else if (input2[i] == 'n' && input2[i + 1] == 'o' && input2[i + 2] == 'p')
            {
                result2[z] = "2";
            }
            else if (input2[i] == 'c' && input2[i + 1] == 'y' && input2[i + 2] == 'k')
            {
                result2[z] = "3";
            }
            else if (input2[i] == 'm' && input2[i + 1] == 'i' && input2[i + 2] == 'n')
            {
                result2[z] = "4";
            }
            else if (input2[i] == 'm' && input2[i + 1] == 'a' && input2[i + 2] == 'r')
            {
                result2[z] = "5";
            }
            else if (input2[i] == 'k' && input2[i + 1] == 'o' && input2[i + 2] == 'n')
            {
                result2[z] = "6";
            }
            else if (input2[i] == 'i' && input2[i + 1] == 'v' && input2[i + 2] == 'a')
            {
                result2[z] = "7";
            }
            else if (input2[i] == 'o' && input2[i + 1] == 'g' && input2[i + 2] == 'i')
            {
                result2[z] = "8";
            }
            else if (input2[i] == 'y' && input2[i + 1] == 'a' && input2[i + 2] == 'n')
            {
                result2[z] = "9";
            }

            z++;
        }

        string finalResult1 = String.Join("",result1);
        string finalResult2 = String.Join("", result2);

        BigInteger realInt1 = BigInteger.Parse(finalResult1);
        BigInteger realInt2 = BigInteger.Parse(finalResult2);

        //operation

        BigInteger digitOutput = 0;

        if (operation == "+")
        {
            digitOutput = realInt1 + realInt2;
        }
        else
        {
           digitOutput = realInt1 - realInt2;
        }

        //Console.WriteLine(digitOutput);

        //make final string output

        string myString = digitOutput.ToString();

        char[] finalCombination = myString.ToCharArray();
        string[] output = new string[finalCombination.Length];

        int y = 0;

        for (int i = 0; i < finalCombination.Length; i++)
        {
            if (finalCombination[i] == '0')
            {
                output[y] = "cad";
            }
            else if (finalCombination[i] == '1')
            {
                output[y] = "xoz";
            }
            else if (finalCombination[i] == '2')
            {
                output[y] = "nop";
            }
            else if (finalCombination[i] == '3')
            {
                output[y] = "cyk";
            }
            else if (finalCombination[i] == '4')
            {
                output[y] = "min";
            }
            else if (finalCombination[i] == '5')
            {
                output[y] = "mar";
            }
            else if (finalCombination[i] == '6')
            {
                output[y] = "kon";
            }
            else if (finalCombination[i] == '7')
            {
                output[y] = "iva";
            }
            else if (finalCombination[i] == '8')
            {
                output[y] = "ogi";
            }
            else if (finalCombination[i] == '9')
            {
                output[y] = "yan";
            }

            y++;
        }

        foreach (var item in output)
        {
            Console.Write(item);
        }

        Console.WriteLine();
    }
}

