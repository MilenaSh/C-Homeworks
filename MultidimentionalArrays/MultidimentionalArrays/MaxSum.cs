using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxSum
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] size = input.Split(' ');
        int rows = int.Parse(size[0]);
        int colls = int.Parse(size[1]);

        int[,] matrix = new int[rows, colls];

        for (int row = 0; row < rows; row++)
        {
            string matrixData = Console.ReadLine();
            string[] matrixSplit = matrixData.Split(' ');
            int index = 0;
            for (int col = 0; col < matrixSplit.Length; col++)
            {
                        
                matrix[row, col] = int.Parse(matrixSplit[index]);
                index++;
            }
        }


        int bestSum = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {

            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] +
                    matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 2, col + 1] +
                    matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }

        Console.WriteLine(bestSum);

    }
}

