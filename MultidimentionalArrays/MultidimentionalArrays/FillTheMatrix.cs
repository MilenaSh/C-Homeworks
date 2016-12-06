using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillTheMatrix
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char ch = char.Parse(Console.ReadLine());

        int currentNumb = 1;
        int[,] matrix = new int[n, n];

        int row = 0;
        int col = 0;

        if (ch == 'c')
        {
            row = n - 1;
        }

        char direction = 'd';

        do
        {
            matrix[row, col] = currentNumb;
            currentNumb++;
            switch (ch)
            {
                case 'a':
                    ProceedA(n, ref currentNumb, ref row, ref col);
                    break;
                case 'b':
                    ProceedB(n, ref currentNumb, ref row, ref col);
                    break;
                case 'c':
                    ProceedC(n, ref currentNumb, matrix, ref row, ref col);
                    break;
                case 'd':
                    ApplyNewDirection(ref direction, ref row, ref col, matrix, n);
                    Move(ref row, ref col, direction);
                    break;
            }

        } while (currentNumb <= n * n);
        PrintMatrix(n, matrix);
    }

    private static void ApplyNewDirection(ref char direction, ref int row, ref int col, int[,] matrix, int n)
    {
        switch (direction)
        {
            case 'd':
                if (row + 1 == n || matrix[row + 1, col] != 0)
                {
                    direction = 'r';
                }
                break;
            case 'r':
                if (col + 1 == n || matrix[row, col + 1] != 0)
                {
                    direction = 'u';
                }
                break;
            case 'u':
                if (row == 0 || matrix[row - 1, col] != 0)
                {
                    direction = 'l';
                }
                break;
            case 'l':
                if (col == 0 || matrix[row, col - 1] != 0)
                {
                    direction = 'd';
                }
                break;
        }
    }

    private static void Move(ref int row, ref int col, char direction)
    {
        switch (direction)
        {
            case 'd':
                row++;
                break;
            case 'r':
                col++;
                break;
            case 'u':
                row--;
                break;
            case 'l':
                col--;
                break;
        }
    }

    private static void ProceedC(int n, ref int currentNumb, int[,] matrix, ref int row, ref int col)
    {
        bool hitsBottom = row == n - 1 || col == n - 1 || matrix[row + 1, col + 1] != 0;
        if (hitsBottom && currentNumb <= n * n)
        {
            FindPlace(n, matrix, ref row, ref col);
        }
        else
        {
            row++;
            col++;
        }
    }

    private static bool FindPlace(int n, int[,] matrix, ref int row, ref int col)
    {
        int tempRow = n - 1;
        int tempCol = 0;
        do
        {
            if (matrix[tempRow, tempCol] == 0)
            {
                row = tempRow;
                col = tempCol;
                return true;
            }
            if (tempRow > 0)
            {
                tempRow--;
            }
            else if (tempCol < n)
            {
                tempCol++;
            }
            else
            {
                return false;
            }

        } while (true);

    }

    private static void PrintMatrix(int n, int[,] matrix)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j]);
                if (j != n - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    private static void ProceedA(int n, ref int currentNumb, ref int row, ref int col)
    {
        row++;
        if (row == n)
        {
            col++;
            row = 0;
        }
    }

    private static void ProceedB(int n, ref int currentNumb, ref int row, ref int col)
    {
        if (col % 2 == 0)
        {

            if (row == n - 1)
            {
                col++;
            }
            else
            {
                row++;
            }
        }
        else
        {
            if (row == 0)
            {
                col++;
            }
            else
            {
                row--;
            }
        }
    }
}
