using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3
{
    class CalculationProblem
    {
        static void Main()
        {
            //read from console

            string input = Console.ReadLine();
            string[] separatedInput = input.Split(' ');


            //calculate in decimal
            int counter = 0;

            foreach (var item in separatedInput)
            {
                string newItem = ReverseString(item);
    
                for (int i = 0; i < newItem.Length; i++)
                {
                    int character = newItem[i] - 97;

                        counter += (int)(character * Math.Pow(23, i));
                    
                }
            }

            int counterFinal = counter;
            StringBuilder result = new StringBuilder();
            //opposite
            while (counter > 0)
            {
                int symbol = counter % 23;
                symbol += 97;
                result.Append((char)symbol);
                counter = counter / 23;
            }

            string final = ReverseString(result.ToString());
            Console.WriteLine("{0} = {1}", final, counterFinal);
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
