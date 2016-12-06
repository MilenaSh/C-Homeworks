using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace Strings
{
    class Demo
    {
        static void Main(string[] args)
        {
            string s = 42.ToString();

            //comparing strings
            string str1 = "add";
            string str2 = "kald";
            string.Compare(str1, str2, true);

            // -1 - means that the first is before the second one
            //true - ignore case

            //concatenation

            string str = String.Concat(str1, str2);

            string result = string.Format("{0}, {1}", str1, str2);

            //Searching in a string

            string name = "Telerik Academy";

            int index = name.IndexOf("Acad");
            //gives the position of the first letter
            //like an array we count from 0;

            //looking for a letter

            int ind = 0;

            while (ind >= 0)
            {
                ind = name.IndexOf("e", ind + 1);
                //without first index
            }

            //l

            string filename = @"C:\Pics\Summer2009.jpg";
            int extindex = filename.LastIndexOf('.');
            string nameAndExtension = filename.Substring(index + 1);
            // nameAndExtension is Summer2009.jpg

            //index substracting

            // string.Substring(int startIndex, int length);

            //Split 

            //string[] string.Split(params char[]);

            //splitting without empty spaces
            string list = "Amstel, Zagorka";

           var nums = list.Split(new char[] { ',', ' ', '.'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            var nums2 = list.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var item in nums2)
            {
                Console.WriteLine(item);
            }

            //Reaplacing

            string cocktail = "Vodka + Martini + Cherry";
            string newCocktail = cocktail.Replace("+", "and"); // Vodka and Martini and Cherry

            //Remove

            string price = "$ 1234567";
            string lowPrice = price.Remove(2, 3); // $ 4567
            //from second index cuts 3

            //Using string.Trim()

            string example = "    example of white space    ";
            string clean = example.Trim();
            Console.WriteLine(clean); // "example of white space"

            //StringBuilder in System.Text

            //we specify capacity1000 if we want
            StringBuilder sb = new StringBuilder(1000);
            sb.Append(str1);
            sb.Append(str2);
            string result2 = sb.ToString();

            //insert - adds at the begining or the end - depending on the given index

            //cannot append and array

            sb.Insert(3, "another");
            string result3 = sb.ToString();
            Console.WriteLine(result3);

            //podravnqvane

            Console.WriteLine("{0,10:F5}");  // to left;
            Console.WriteLine("{0,-10:F5}"); // to right;

            //Empty, null, 

            string str5 = null;
            string str6 = "";
            string str7 = string.Empty;

            //null means no address

            //Clearing a Bulder
            sb.Clear();

            string[] array = new string[5];
            Array.Clear(array, 0, array.Length);
        }
    }
}
