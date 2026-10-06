using System;
using System.Collections.Generic;
using System.Text;

namespace RegularExample
{
    public class Matrix
    {
        public static int[,] Add(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0); // getting length of first diamention
            int columns = matrix1.GetLength(1); // getting length of second diamention

            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    result[i, j] = matrix1[i, j] + matrix2[i, j];

            return result;

        }

        public static void Print(int[,] finalMatrix)
        {
            int rows = finalMatrix.GetLength(0);
            int columns = finalMatrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write(finalMatrix[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
