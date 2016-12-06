using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class EnglishWord
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string finalResult = ReturnAsWord(number);
            Console.WriteLine(finalResult);
        }

        static string ReturnAsWord(int number)
        {
            int lastDigit = number % 10;
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string result = digits[lastDigit];

            return result;
        }

    }



