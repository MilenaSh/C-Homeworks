using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CorrectBrackets
{
    static void Main()
    {
        string expression = Console.ReadLine();

        int openning = 0;
        int closing = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                openning += 1;
            }
            else if (expression[i] == ')')
            {
                closing += 1;
            }
        }

        if (openning == closing)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}

