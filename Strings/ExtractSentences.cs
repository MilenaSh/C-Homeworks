using System;
using System.Text;

namespace _08.ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string[] sentences = text.Split('.');
            StringBuilder temp = new StringBuilder();
            StringBuilder result = new StringBuilder();

            foreach (var sentence in sentences)
            {
                temp.Clear();
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (char.IsLetter(sentence[i]) == false)
                    {
                        temp.Append(sentence[i]); //parse NON-letter symbols
                    }
                }
                char[] splitChars = temp.ToString().ToCharArray();
                string[] words = sentence.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

                if (Array.IndexOf(words, word) > -1)
                {
                    result.Append(sentence.Trim());
                    result.Append(". ");
                }
            }
            //print
            Console.WriteLine(result.ToString().Trim());

            
        }
    }
}


class ExtractSentences
{
    static void Main()
    {
        string word = Console.ReadLine();
        string fullWord = " " + word + " ";
        string wordSign = word + ".";
        string wordSign2 = word + "!";
        string wordSign3 = word + "?";

        //to upper

        string firstLetter = word[0].ToString().ToUpper();
        StringBuilder toUpper = new StringBuilder();
        toUpper.Append(firstLetter);

        for (int i = 1; i < word.Length; i++)
        {
            toUpper.Append(word[i]);
        }
        toUpper.Append(" ");
        string upperFirst = toUpper.ToString();

        string text = Console.ReadLine();

        StringBuilder result = new StringBuilder();
        int j = 0;

        for (int i = 0; i < text.Length; i++)
        {

            if (text[i] == '.' || text[i] == '?' || text[i] == '!')
            {
                int endIndex = text[i];
                string sentense = null;

                sentense = text.Substring(j, i - j + 1);

                int wordMatch = sentense.IndexOf(fullWord);
                int wordMatchSign = sentense.IndexOf(wordSign);
                int wordMatchSign2 = sentense.IndexOf(wordSign2);
                int wordMatchSign3 = sentense.IndexOf(wordSign3);
                int wordFirstUpper = sentense.IndexOf(upperFirst);
                if (wordMatch > 0 || wordMatchSign > 0 || wordMatchSign2 > 0 || wordMatchSign3 > 0 || wordFirstUpper > 0)
                {
                    result.Append(sentense.Trim());
                   
                }
                //string newString = text.Substring(i, text.Length - i);
                //text = newString;
                j = i + 1;
            }

        }


        string finalResult = result.ToString();
        Console.WriteLine(finalResult);
    }
}


