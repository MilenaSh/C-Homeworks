using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSystems
{

    class BitsShort
    {
        public short reverseBitsShort(int x)
        {
            int intSize = 16;
            int y = 0;
            for (int position = intSize - 1; position > 0; position--)
            {
                y += ((x & 1) << position);
                x >>= 1;
            }
            return y;
        }
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            long remainder = 0;

            string result = string.Empty;

            if (number > 0)
            {
                while (number > 0)
                {
                    remainder = number % 2;
                    result = remainder.ToString() + result;
                    number = number / 2;

                }
                string newResult = result.PadLeft(16, '0');

                Console.WriteLine(newResult);
            }

            else
            {
                number += -2 * number;
                while (number > 0)
                {
                    remainder = number % 2;

                    result = remainder.ToString() + result;
                    number = number / 2;

                }
                string newResult = result.PadLeft(16, '0');
                char[] printArea = newResult.ToCharArray();

                for (var i = 0; i < printArea.Length; i++)
                {
                    if (i == printArea.Length - 1)
                    {
                        Console.Write('1');
                        break;
                    }
                    if (printArea[i] == '1')
                    {
                        Console.Write(0);
                    }
                    else if (printArea[i] == '0')
                    {
                        Console.Write(1);
                    }




                }


            }
        }


    }
}

