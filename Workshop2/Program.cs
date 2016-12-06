using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    class Program
    {
        static void Main()
        {
            //read input
            string input = Console.ReadLine();

           
            //getting the cypher

            StringBuilder cypherLenght = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] >= 48 && input[i] <=57)
                {
                    cypherLenght.Append(input[i]);
                }
                else
                {
                    break;
                }
            }

            string cypher = cypherLenght.ToString();
            string cypherFinal = ReverseString(cypher);

            int realCypher = int.Parse(cypherFinal);

            //full lenght of the string

            StringBuilder full = new StringBuilder();

            for (int i = 0; i < input.Length - cypherFinal.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {                
                   string  temp = new String(input[i + 1], input[i] - 49);
                    full.Append(temp);
                }
                else if ((input[i] >= 48 && input[i] <= 57) && (input[i + 1] >= 48 && input[i +1] <= 57))
                {
                   // string temp1 = (char)(input[i] - 48) + (char)(input[i + 1] -48) +"";
                    string temp1 = string.Concat((input[i] - 48), (input[i + 1] - 48));
                    int twoDigits = int.Parse(temp1);
                    string temp = new String(input[i + 2], twoDigits);
                    Console.WriteLine(temp1);
                }
                else
                {
                    full.Append(input[i]);
                }
            }

            string final = full.ToString();
           // Console.WriteLine(two);
         
      

            // get the cypher of the full string

            string cypherToUse = final.Substring( final.Length - realCypher, realCypher);
        

            string message = final.Substring(0, final.Length - realCypher);
       

            //decripting
     
            if (message.Length > cypherToUse.Length)
            {
                int j = 0;

                for (int i = 0; i < message.Length; i++)
                {
                    if (j == cypherToUse.Length)
                    {
                        j = 0;
                    }
                    char first = (char)(message[i] - 65);
                    char second = (char)(cypherToUse[j] - 65);
                    int temp = ((int)first ^ (int)second) + 65;
                 
                    Console.Write((char)temp);
                    j++;
      
                }
            }
            else if (message.Length < cypherToUse.Length)
            {
                int[] array = new int[message.Length ];
  

                for (int z = 0; z < array.Length; z++)
                {
                    array[z] = message[z];
                }
                int j = 0;

                for (int i = 0; i < cypherToUse.Length; i++)
                {
                    if (j == array.Length)
                    {
                        j = 0;
                    }
                    char first = (char)(cypherToUse[i] - 65);
                    char second = (char)(array[j] - 65);
                    int temp = ((int)first ^ (int)second) + 65;
                    array[j] = temp;
     
                    j++;

                }
                foreach (var item in array)
                {
                    Console.Write((char)item);
                }

            }
            else
            {
                int[] array = new int[message.Length];


                for (int z = 0; z < array.Length; z++)
                {
                    array[z] = message[z];
                }
                int j = 0;

                for (int i = 0; i < cypherToUse.Length; i++)
                {

                    char first = (char)(cypherToUse[i] - 65);
                    char second = (char)(array[j] - 65);
                    int temp = ((int)first ^ (int)second) + 65;
                    array[j] = temp;

                    j++;

                }
                foreach (var item in array)
                {
                    Console.Write((char)item);
                }
            }


        }


        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
