using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IntDoubleString
{
    static void Main()
    {
        string inputType = Console.ReadLine();

        switch (inputType)
        {
            case "text":
                string word = Console.ReadLine();
                Console.WriteLine(word + "*");
                break;
            case "integer":
                int wholeN = int.Parse(Console.ReadLine());
                Console.WriteLine(++wholeN);
                break;
            case "real":
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.00}",++number);
                break;
        }
    }
}

