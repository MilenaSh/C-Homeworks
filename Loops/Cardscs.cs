using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Cardscs
{
    static void Main()
    {
        string card = Console.ReadLine();
        string[] arraycards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        foreach (string n in arraycards)
        {
            Console.WriteLine(n + " of spades, " + n + " of clubs, " + n + " of hearts, " + n + " of diamonds ");

            if (card == n)
            {
                break;
            }
        }
    }
}


