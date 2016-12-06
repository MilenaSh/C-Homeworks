using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class ParseURL
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder protocol = new StringBuilder();
            StringBuilder server = new StringBuilder();
            StringBuilder resource = new StringBuilder();

            int prot = input.IndexOf("://", 0);

            for (int i = 0; i < prot; i++)
            {
                protocol.Append(input[i]);
            }

            string protocolResult = protocol.ToString();

            string newInput = input.Substring(prot + 3, input.Length - prot - 3);
      

            int ser = newInput.IndexOf("/");

            for (int i = 0; i < ser; i++)
            {
                server.Append(newInput[i]);
            }

            string serverResult = server.ToString();

            string resourceResult = newInput.Substring(ser, newInput.Length - ser);

            Console.WriteLine("[protocol] = {0}", protocolResult);
            Console.WriteLine("[server] = {0}", serverResult);
            Console.WriteLine("[resource] = {0}", resourceResult);

        }
    }
}
