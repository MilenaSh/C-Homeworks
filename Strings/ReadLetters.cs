using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class ReadLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder text = new StringBuilder();

            char current = input[0];
            text.Append(input[0].ToString());

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != current)
                {
                    text.Append(input[i].ToString());
                    current = input[i];
                }
            }

            string result = text.ToString();
            Console.WriteLine(result);
        }
    }
}
