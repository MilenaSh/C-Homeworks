using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ParseTags
{
    static void Main()
    {
        string input = Console.ReadLine();

        string begining = "<upcase>";
        string edning = "</upcase>";
        StringBuilder result = new StringBuilder();

        int i = 0;
        int oldIndex = 0;

        while (i <= input.Length)
        {
            //find the begining
            int index = input.IndexOf(begining, i);
            if (index == -1)
            {
                string finalPhrase = input.Substring(i, input.Length - i);
                result.Append(finalPhrase);
                break;
            }
            // find ending
            int index2 = input.IndexOf(edning, i);
            //get the clean text
            string subBetween = input.Substring(i, (index));
            //get the middle text
            result.Append(subBetween);

            string phrase = input.Substring(index + 8, index2 - (index +8));
            string phraseUpper = phrase.ToUpper();
            result.Append(phraseUpper);

            string newInput = input.Substring(index2 + 9, input.Length -( index2 +9));

            input = newInput;
        }

        string final = result.ToString();
        Console.WriteLine(final);


    }
}

