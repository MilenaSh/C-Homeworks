using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

class BiggestPrime
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        bool[] nums = new bool[size + 1];

        int biggestPrime = 0;

        for (int i = 2; i < Math.Sqrt(nums.Length); i++)
        {
            if (nums[i] == false)
            {
                for (int j = i * i; j < nums.Length; j = j + i)
                {
                    nums[j] = true;
                }
            }
        }
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] == false)
            {
                if (i > biggestPrime)
                {
                    biggestPrime = i;
                }
            }
        }
        Console.WriteLine(biggestPrime);
    }
}