using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Char
{
    static void Main()
    {
        /*char symbol = 'c';
        Console.WriteLine((int)symbol);

        //default value '\0'
        // reading with Parse

        char symbols = (char)Console.Read();
        Console.WriteLine(symbols);
        Console.WriteLine((int)symbols);

        char symbolWithOffset = ((char)(symbols + 5));
        Console.WriteLine(symbolWithOffset);*/

        // Declare a variable
        char ch = 'a';
        // Print the results on the console
        Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);
        ch = 'b';
        Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);
        ch = 'A';
        Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);
        Console.ReadLine();
        //For Cyrilic we can change the Output endcoding to Unicode. For that we need using System.Text;
    }
}

