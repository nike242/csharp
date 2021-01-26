using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] a = new int[6][];
            a[0] = new int[4];
            a[1] = new int[2];
            a[2] = new int[4];
            a[3] = new int[3];
            a[4] = new int[4];
            a[5] = new int[1];

            foreach (var item in a)
            {
                foreach (var e in item)
                {
                    Console.Write($"{e}");
                }
                Console.WriteLine();
            }

            //int[,,] matrixA = new int[4, 1, 6];

            //Random r = new Random();

            //int[,] matrixA = new int[4, 1];
            //FillMatrix(ref matrixA, r);
            //PrintMatrix(matrixA);

            //int[,] matrixB = new int[1, 2];
            //FillMatrix(ref matrixB, r);
            //PrintMatrix(matrixB);

            //int[,] matrixResult = new int[4, 2];

            //for (int i = 0; i < matrixA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrixB.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < matrixA.GetLength(1); k++)
            //        {
            //            matrixResult[i, j] += matrixA[i, k] * matrixB[k, j];
            //        }
            //        Console.Write($"{matrixResult[i, j],3}");
            //    }
            //    Console.WriteLine();
            //}

        }

        private static void PrintMatrix(int[,] matrix)
        {
            var row = matrix.GetLength(0);
            var cols = matrix.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void FillMatrix(ref int[,] matrix, Random r)
        {
            var row = matrix.GetLength(0);
            var cols = matrix.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = r.Next(10);
                }

            }
        }
    }
}
