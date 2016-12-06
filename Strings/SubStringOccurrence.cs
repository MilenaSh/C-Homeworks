using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SubStringOccurrence
{
    static void Main()
    {
        string inputPattern = Console.ReadLine();
        string pattern = inputPattern.ToUpper();
        string inputText = Console.ReadLine();
        string text = inputText.ToUpper();



        int index = 0;
        int counter = 0;

        while (index <= text.Length)
        {
            int result = text.IndexOf(pattern, index);
            index = result + pattern.Length;
            if (result == -1)
            {
                break;
            }
            else
            {
                counter += 1;
            }
        }
        Console.WriteLine(counter);

    }
}

