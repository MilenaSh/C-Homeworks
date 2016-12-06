using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class LoverOf3
{
    static void Main()
    {
        //read matrix
        string dimentions = Console.ReadLine();
        string[] dimentions2 = dimentions.Split(' ');
        int rows = int.Parse(dimentions2[0]);
        int cols = int.Parse(dimentions2[1]);

        //read moves
        int numberMoves = int.Parse(Console.ReadLine());

        string[] moves = new string[numberMoves];
        int[] count = new int[numberMoves];

        for (int i = 0; i < numberMoves; i++)
        {
            string step1 = Console.ReadLine();
            string[] step2 = step1.Split(' ');
            moves[i] = step2[0];
            count[i] = int.Parse(step2[1]);
        }


        //fill the matrix
        long[,] matrix = FillMatrix(rows, cols);

        // PrintMatrix(rows, cols, matrix);

        //go through the matrix

        int currentRow = rows - 1;
        int currentCol = 0;

        BigInteger sum = 0;


        for (int i = 0; i < moves.Length; i++)
        {

            
            switch (moves[i])
            {
                case "UR":
                case "RU":
                    while (count[i] > 1)
                    {
                        bool isGoingOutMatrix = (currentRow > rows - 1) || (currentRow < 0) || (currentCol > cols - 1) || (currentCol < 0);
                        if (!isGoingOutMatrix)
                        {
                            MakeStep(count, matrix, currentRow, currentCol,ref sum, i);
                            currentRow--;
                            currentCol++;
                        }
                        else
                        {
                            currentRow++;
                            currentCol--;
                            break;
                        }
                    }
                    break;
                case "DR":
                case "RD":
                    while (count[i] > 1)
                    {
                        bool isGoingOutMatrix = (currentRow > rows - 1) || (currentRow < 0) || (currentCol > cols - 1) || (currentCol < 0);
                        if (!isGoingOutMatrix)
                        {
                            MakeStep(count, matrix, currentRow, currentCol,ref sum, i);
                            currentRow++;
                            currentCol++;
                        }
                        else
                        {
                            currentRow--;
                            currentCol--;
                            break;
                        }
                    }
                    break;
                case "UL":
                case "LU":
                    while (count[i] > 1)
                    {
                        bool isGoingOutMatrix = (currentRow > rows - 1) || (currentRow < 0) || (currentCol > cols - 1) || (currentCol < 0);
                        if (!isGoingOutMatrix)
                        {
                            MakeStep(count, matrix, currentRow, currentCol,ref sum, i);
                            currentRow--;
                            currentCol--;
                        }
                        else
                        {
                            currentRow++;
                            currentCol++;
                            break;
                        }

                    }
                    break;
                case "DL":
                case "LD":
                    while (count[i] > 1)
                    {
                        bool isGoingOutMatrix = (currentRow > rows - 1) || (currentRow < 0) || (currentCol > cols - 1) || (currentCol < 0);
                        if (!isGoingOutMatrix)
                        {
                            MakeStep(count, matrix, currentRow, currentCol,ref sum, i);
                            currentRow++;
                            currentCol--;
                        }
                        else
                        {
                            currentRow--;
                            currentCol++;
                            break;
                        }
                    }
                    break;
            }
        }

        bool hasToAddLastItem = (currentRow <= rows - 1) && (currentRow >= 0) && (currentCol <= cols - 1) && (currentCol >= 0);
        if (hasToAddLastItem)
        {
            sum += matrix[currentRow, currentCol];
        }

        Console.WriteLine(sum);
    }

    private static void PrintMatrix(int rows, int cols, BigInteger[,] matrix)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    private static long[,] FillMatrix(int rows, int cols)
    {
        long[,] matrix = new long[rows, cols];

        int z = 0;
        for (int i = rows - 1; i >= 0; i--)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = (j + z) * 3;
            }
            z++;
        }

        return matrix;
    }

    private static void MakeStep(int[] count, long[,] matrix, int currentRow, int currentCol,ref BigInteger sum, int i)
    {
        sum += matrix[currentRow, currentCol];
        matrix[currentRow, currentCol] = 0;
        count[i]--;
    }
}

