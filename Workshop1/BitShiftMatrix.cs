using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Workshop1
{
    class BitShiftMatrix
    {
        static void Main()
        {
            //read matrix dimentions

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int movesNumber = int.Parse(Console.ReadLine());

            string steps = Console.ReadLine();
            string[] stepsToDo = steps.Split(' ');


            //creating the matrix

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = 1;
                }
            }

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }

            //    Console.WriteLine();
            //}


            //get coordinates

            //coefficient

            int coef = GetCoef(rows, cols);

            int coordinateRow = 0;
            int coordinateCol = 0;

            int[] movementsRows = new int[stepsToDo.Length];

            for (int i = 0; i < stepsToDo.Length; i++)
            {
                int step = int.Parse(stepsToDo[i]);
                coordinateRow = GetRow(step, coef);
            }

            int[] movementsCols = new int[stepsToDo.Length];

            for (int i = 0; i < stepsToDo.Length; i++)
            {
                int step = int.Parse(stepsToDo[i]);
                coordinateCol = GetCol(step, coef);
            }


            //go through the matrix

            BigInteger sum = 0;

            int z = 0;
            int initialRows = rows - 1;
            int initialCols = 0;

            for (int i = initialCols; i < movementsCols[z]; i++)
            {
                sum += matrix[initialRows, i] *(BigInteger) Math.Pow(2, (i+ initialRows));
                matrix[initialRows, i] = 0;

                initialCols = movementsCols[z] - 1;

                for (int j = initialRows; j >= movementsRows[z]; j--)
                {

                }
            }

            for (int i = initialRows; i >= movementsRows[z]; i++)
            {

                for (int j = 0; j < cols; j++)
                {
                    int positionRows = movementsRows[j];
                    int positionCols = movementsCols[j];

                }
            }


        }


        private static int GetRow(int row, int coef)
        {
            int rowPosition = row / coef;
 
            return rowPosition;

        }

        private static int GetCol( int col, int coef)
        {
            int colPosition = col % coef;

            return colPosition;
        }

        private static int GetCoef(int row, int col)
        {
            int coef = row;

            if (row > col)
            {
                coef = col;
            }
            return coef;
        }
    }
}
