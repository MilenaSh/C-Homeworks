using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequenceInMatrix
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] size = input.Split(' ');
        int rows = int.Parse(size[0]);
        int colls = int.Parse(size[1]);
        //

        string[,] matrix = new string[rows, colls];

        for (int row = 0; row < rows; row++)
        {
            string matrixData = Console.ReadLine();
            string[] matrixSplit = matrixData.Split(' ');
            int index = 0;
            for (int col = 0; col < matrixSplit.Length; col++)
            {

                matrix[row, col] = matrixSplit[index];
                index++;
            }
        }

        // check 

        int counter = 0;
        int counterMax = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {

            for (int col = 1; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    counter += 1;
                    for (int _row = row; _row < matrix.GetLength(0) - 1 - row; _row++)
                    {
                        int _col = col;
                        if (matrix[_row, _col] == matrix[_row + 1, _col])
                        {
                            counter += 1;
                            if (counter > counterMax)
                            {
                                counterMax = counter;
                            }
                        }

                    }
                    counter = 0;
                }
                else if (matrix[row, col] == matrix[row, col + 1])
                {
                    counter += 1;
                    for (int _col = col; _col < matrix.GetLength(1) - 1 - col; _col++)
                    {
                        int _row = row;
                        if (matrix[_row, _col] == matrix[_row, _col + 1])
                        {
                            counter += 1;
                        }

                        if (counter > counterMax)
                        {
                            counterMax = counter;
                        }
                    }

                    counter = 0;
                }
                else if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    counter += 1;
                    for (int _col = col, _row = row; (_col < matrix.GetLength(1) - 1 - col) && (_row < matrix.GetLength(0) - 1 - row); _col++, _row++)
                    {
                        //int _row = row;
                        if (matrix[_row, _col] == matrix[_row + 1, _col + 1])
                        {
                            counter += 1;
                        }
                        if (counter > counterMax)
                        {
                            counterMax = counter;
                        }
                    }

                    counter = 0;
                }
                else if (matrix[row, col] == matrix[row + 1, col - 1])
                {
                    counter += 1;
                    for (int _col = col, _row = row; (_col > 0) && (_row < matrix.GetLength(0) - 1); _col--, _row++)
                    {
                        //int _row = row;
                        if (matrix[_row, _col] == matrix[_row + 1, _col - 1])
                        {
                            counter += 1;
                        }
                        if (counter > counterMax)
                        {
                            counterMax = counter;
                        }
                    }

                    counter = 0;
                }
            }
        }

        // int col = 0;

        for (int row = matrix.GetLength(0) - 1, col = 0; col < matrix.GetLength(1) - 1; col++)
        {
            if (matrix[row, col] == matrix[row, col + 1])
            {
                counter += 1;
                if (counter > counterMax)
                {
                    counterMax = counter;
                }
            }
        }

        counter = 0;

        for (int col = matrix.GetLength(1) - 1, row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            if (matrix[row, col] == matrix[row + 1, col])
            {
                counter += 1;
                if (counter > counterMax)
                {
                    counterMax = counter ;
                }
            }
        }

        Console.WriteLine(counterMax);

    }
}

using System;


namespace _03.SequenceInMatrix
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/02.%20Multidimensional-Arrays/homework/03.%20Sequence%20in%20matrix/README.md
            //input and values
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);  //rows
            int m = int.Parse(input[1]);  //cols

            string[,] MasterMatrix = new string[n, m]; //create Master Matrix from user's values
            for (int row = 0; row < n; row++)
            {
                string[] tempStr = Console.ReadLine().Split(' ');
                for (int col = 0; col < m; col++)
                {
                    MasterMatrix[row, col] = tempStr[col];
                }
            }

            int[,] longestSequenceMatrix = new int[n, m]; //this matrix will keep only the number of equal elements. This is "dynamic programing" technique. See: 01.Arrays\18.RemoveElementsFromArray
            for (int row = 0; row < n; row++) //define all element with value "1"
            {
                for (int col = 0; col < m; col++)
                {
                    longestSequenceMatrix[row, col] = 1;
                }
            }

            //calculation
            MasterMatrixCalculation(n, m, MasterMatrix, longestSequenceMatrix);
            //print
            int result = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (result < longestSequenceMatrix[row, col])
                    {
                        result = longestSequenceMatrix[row, col];
                    }
                }
            }
            Console.WriteLine(result);
        }

        static void MasterMatrixCalculation(int n, int m, string[,] MasterMatrix, int[,] longestSequenceMatrix)
        {
            //matrix
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    //create a sub matrix for check each element of master matrix
                    //top side
                    for (int top = 0; top < 3; top++)
                    {
                        if (((row - 1) < 0) || (((col - 1) + top < 0) || (((col - 1) + top) > m - 1)))
                        {
                            continue;
                        }
                        else
                        {
                            if (MasterMatrix[(row - 1), ((col - 1) + top)] == MasterMatrix[row, col])
                            {
                                longestSequenceMatrix[row, col] += longestSequenceMatrix[(row - 1), ((col - 1) + top)];
                                longestSequenceMatrix[(row - 1), ((col - 1) + top)] = 0;
                            }
                        }
                    }
                    //right side
                    if (!((col + 1) > m - 1))
                    {
                        if (MasterMatrix[row, (col + 1)] == MasterMatrix[row, col])
                        {
                            longestSequenceMatrix[row, col] += longestSequenceMatrix[row, (col + 1)];
                            longestSequenceMatrix[row, (col + 1)] = 0;
                        }
                    }
                    //left side
                    if (!((col - 1) < 0))
                    {
                        if (MasterMatrix[row, (col - 1)] == MasterMatrix[row, col])
                        {
                            longestSequenceMatrix[row, col] += longestSequenceMatrix[row, (col - 1)];
                            longestSequenceMatrix[row, (col - 1)] = 0;
                        }
                    }
                    //bottom side
                    for (int bottom = 0; bottom < 3; bottom++)
                    {
                        if (((row + 1) > n - 1) || (((col - 1) + bottom < 0) || (((col - 1) + bottom) > m - 1)))
                        {
                            continue;
                        }
                        else
                        {
                            if (MasterMatrix[(row + 1), ((col - 1) + bottom)] == MasterMatrix[row, col])
                            {
                                longestSequenceMatrix[row, col] += longestSequenceMatrix[(row + 1), ((col - 1) + bottom)];
                                longestSequenceMatrix[(row + 1), ((col - 1) + bottom)] = 0;
                            }
                        }
                    }
                }
            }
        }
    }
}