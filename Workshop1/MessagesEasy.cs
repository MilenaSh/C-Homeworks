using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Workshop1
{

    class MessagesEasy
    {
        static string[] numSystem = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

        static void Main()
        {
            string strOne = Console.ReadLine();
            string op = Console.ReadLine();
            string strTwo = Console.ReadLine();

            BigInteger numOne = Decrypt(strOne);
            BigInteger numTwo = Decrypt(strTwo);

            BigInteger numResult = 0;

            string result = Encrypt(numResult);


        }

        private static string Encrypt(BigInteger num)
        {
            string result = "";

            int digit = (int)(num % 10);

            result += 0;

            return result;

            //throw new NotImplementedException();
        }

        private static BigInteger Decrypt(string str)
        {
            BigInteger result = 0;

            string digit = str.Substring(0, 3);

            for (int j = 0; j < str.Length; j+= 3)
            {

                digit = str.Substring(j, 3);

                for (int i = 0; i < numSystem.Length; i++)
                {
                    if (digit == numSystem[i])
                    {
                        result += result *10 + i;
                    }
                }
            }

            return result;

            //throw new NotImplementedException();
        }
    }
}
