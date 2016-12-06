using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimentionalArrays
{
    class Demos
    {
        static void Main()
        {
            //check problem for Laser - exam 2012/3
            //first dimention - always the rows

            // . Lenght - gives number of all values

            // cube.GetLenght(0) - dava v parvite skobki kolko elementa ima i t.n.

            int[,] matrix = {
                    { 1,2,3},
                     {4,5,6 }
            };

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    Console.WriteLine(matrix[row, col]);
                }
            }


            int[,,] cube = {
                {
                    { 1,2,3},
                     {4,5,6 }
                
                 },
                 {
                     { 1,2,3},
                     { 4,5,6 }
                }
            };

            int count = 1;

            for (int row = 0; row < cube.GetLength(0); row++)
            {
                for (int col = 0; col < cube.GetLength(1); col++)
                {
                    for (int d = 0; d < cube.GetLength(2); d++)
                    {
                        cube[row, col, d] = count;
                        count++;
                    }
                }
            }

            //pri masiv ot masivi default value = null;

            //pring Jagged array

            //massive ot list ot intove

            List<int>[] list = new List<int>[3];

            //System.Array - Class Array

            //Rank – number of dimensions
            //Length – number of all elements through all dimensions
            //GetLength(index) – returns the number of elements in the specified dimension

            //GetEnumerator() – returns IEnumerator for the array elements
            //BinarySearch(…) – searches for a given element into a sorted array(uses binary search)
            //IndexOf(…) – searches for a given element and returns the index of the first occurrence(if any)
            //LastIndexOf(…) – searches for a given element and returns the last occurrence index
            //Copy(src, dest, len) – copies array elements; has many overloads

            int[] nums = { 5, 6, 7, 8, 9, 1, 5, 6, 4 };

            Console.WriteLine(Array.IndexOf(nums, 6));

            // Reverse(…) – inverts the arrays elements upside down
            //Clear(…) – assigns value 0(null) for each elements
            //CreateInstance(…) – creates an array
            //Accepts as parameters the number of dimensions, start index and number of elements
            //Implements ICloneable, IList, ICollection and IEnumerable interfaces

            //SORTING
            //Sorting in .NET is usually done with System.Array.Sort()
            //Sort(Array) – sorts array elements
            //Elements should implement IComparable
            //Sort(Array, IComparer) – sorts array elements by given external IComparer
            //Sort(Array, Comparison<T>) – sorts array elements by given comparison operation
            //Can be used with lambda expression

        }
    }
}
