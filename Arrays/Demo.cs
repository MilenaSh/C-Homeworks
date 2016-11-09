using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Demo
{
    static void Main()
    {
        int[] someNumbers = new int[5] {1, 2, 3, -20, 5};

        // default for 

        object[] things = { 'a', "hello", 16 };

        //separate printing

        Console.WriteLine(things[0]);

        for (int i = 0; i < someNumbers.Length; i++)
        {
            Console.WriteLine(someNumbers[i]);
        }

        foreach (int number in someNumbers)
        {
            Console.WriteLine(number);
        }

        //for last index

        for (int i = someNumbers.Length - 1; i >= 0 ; i--)
        {
            Console.WriteLine(i);
        }

        //change index

        someNumbers[3] = 66;

        //storing numbers in array

        int n = int.Parse(Console.ReadLine());

        int[] numbersFromConsole = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbersFromConsole[1] = int.Parse(Console.ReadLine());
        }


        //how to reverse an array
        ///////////////////

        //first way
        int[] reversedNumbers = new int[someNumbers.Length];

        for (int i = 0; i < someNumbers.Length; i++)
        {
            reversedNumbers[i] = someNumbers[someNumbers.Length - 1 - i];
        }

        //second way

        for (int i = 0; i < someNumbers.Length/2; i++)
        {
            // i
            //someNumbers.Length - 1 - i;

            int store = someNumbers[i];
            someNumbers[i] = someNumbers[someNumbers.Length - 1 - i];
            someNumbers[i] = someNumbers[someNumbers.Length - 1 - i] = store;

        }

        Console.WriteLine(string.Join(", ", someNumbers));

        //////////////////////////////////////
        //Resizable

        int[] otherNumbers = someNumbers;

        otherNumbers[0] = -99;

        Console.WriteLine(someNumbers[0]);

        //make array from string

        //"1 2 3 4 5 7 3444 11"

        int[] numbers = "1 2 3 4 5 7 3444 11".Split(' ').Select(int.Parse).ToArray(); // split per white space

        //Lists

        string[] names = { "pesho", "gosho", "stamat" };
        List<string> nameList = new List<string>() { "pesho", "gosho", "stamat" };

        //lenght = nameList.Count
        nameList.Add("Gosho");

        nameList.Remove("Gosho"); // removes only the first one

        //for specific index
        nameList.RemoveAt(2);

        //copying arrays

        int[] copyOfSomeNumbers = new int[someNumbers.Length];

        for (int i = 0; i < someNumbers.Length; i++)
        {
            copyOfSomeNumbers[i] = someNumbers[i];

        }

        //using clone - we need to cast

        char[] symbols = { 'a', 'b' };
        char[] copiedNames = (char[])symbols.Clone();

        //to chat array
        // Use ToCharArray to convert string to array.

        //char[] array = value.ToCharArray();
        //value- string name


        //
        // Swap characters in the string.
        //
        string value1 = "Dot Net Perls";
       // string swap1 = SwapCharacters(value1, 0, 1);
       // Console.WriteLine(swap1);
        //
        // Swap elements in array.
        //
        int[] array1 = { 1, 2, 3, 4, 5 };
       // SwapInts(array1, 0, 1);
    }
}


