using System;
using System.Text;

/*Write a program that converts a string to a sequence of C# Unicode character literals.Use format strings.
Example:    input 	    output
            Hi! 	    \u0048\u0069\u0021      */

class UnicodeCharacters
{
    static void Main()
    {
        string str = Console.ReadLine();
        byte[] uniByte = Encoding.Unicode.GetBytes(str);
        StringBuilder uniString = new StringBuilder();
        foreach (byte b in uniByte)
        {
            if (b == 0)
            {
                continue;
            }
            uniString.Append( string.Format("{0}{1}", "\\u", b.ToString("X").PadLeft(4, '0')));
        }

        string final = uniString.ToString();
        Console.WriteLine(final);
    }
}