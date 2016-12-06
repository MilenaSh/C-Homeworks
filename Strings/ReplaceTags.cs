using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Strings
{
    using System;


    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string replaceTags = Regex.Replace(text, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");
            Console.WriteLine(replaceTags);
        }
    }
    class ReplaceTags
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int i = 0;

            while (i < input.Length)
            {

                int openTag = input.IndexOf("<a href=", i);

                if (openTag == -1)
                {
                    string finalPhrase = input.Substring(i, input.Length - i);
                    result.Append(finalPhrase);
                    break;
                }

                int closingFirst = input.IndexOf("\">", i);
                int closingSecond = input.IndexOf("</a>", i);

                string text = input.Substring(i, openTag - i);
                result.Append(text);

                string siteName = input.Substring(closingFirst + 2, closingSecond - (closingFirst + 2));
                result.Append("[" + siteName + "]");

                string url = input.Substring(openTag + 9, closingFirst - openTag - 9);
                result.Append("(" + url + ")");

                i = closingSecond +4 ;
            }

            string resultFinal = result.ToString();

            Console.WriteLine(resultFinal);
                
            
        }
    }
}
