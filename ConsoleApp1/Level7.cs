using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level7
    {
        static int ToInt(string s) => int.Parse(s);
        static void Print(int num) { Console.WriteLine(num); }
        static void Print(int num1, int num2) { Console.WriteLine("{0} {1}", num1, num2); }
        static void Print(string s) { Console.WriteLine(s); }
        private static string Read() => Console.ReadLine();

        static void Main(String[] args)
        {
            ex3();
        }

        static int[,] TransMatrix(int[,] matrix, int row, int column)
        {
            for (int i = 0; i < row; i++)
            {
                string rowVal = Read();
                int[] rowValInt = rowVal.Split().Select(x => ToInt(x)).ToArray();
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = rowValInt[j];
                }
            }

            return matrix;
        }

        static int[,] AddMatrix(int[,] matrix1, int[,] matrix2, int row, int column)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix1[i, j] += matrix2[i, j];
                }
            }

            return matrix1;
        }

        static void PrintMatrix(int[,] matrix, int row, int column)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sb.Append(matrix[i, j] + " ");
                }
                sb.Append("\n");
            }

            Console.WriteLine(sb);
        }

        static char[][] TransWords(char[][] matrix, int row)
        {
            for (int i = 0; i < row; i++)
            {
                string rowVal = Read();
                char[] rowValChar = rowVal.ToArray();
                matrix[i] = new char[rowValChar.Length];

                for (int j = 0; j < rowValChar.Length; j++)
                {
                    matrix[i][j] = rowValChar[j];
                }
            }
            return matrix;
        }

        static int FindMaxColumn(char[][] words, int row)
        {
            int maxLength = 0;
            foreach (char[] column in words)
            {
                if (column.Length > maxLength)
                {
                    maxLength = column.Length;
                }
            }
            return maxLength;
        }

        static void PrintToRow(char[][] matrix, int maxColumn)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < maxColumn; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[j].Length <= i)
                        continue;
                    sb.Append(matrix[j][i]);
                }
            }
            Console.WriteLine(sb);
        }

        static void ex1() //matrix row column
        {
            string s = Read();
            int[] size = s.Split().Select(x => ToInt(x)).ToArray();

            int row = size[0];
            int column = size[1];

            int[,] matrix1 = new int[row, column];
            int[,] matrix2 = new int[row, column];

            TransMatrix(matrix1, row, column);
            TransMatrix(matrix2, row, column);

            AddMatrix(matrix1, matrix2, row, column);
            PrintMatrix(matrix1, row, column);
        }

        static void ex2()
        {
            int[,] matrix = new int[9, 9];
            TransMatrix(matrix, 9, 9);

            int max = 0, row = 0, column = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (matrix[i, j] >= max)
                    {
                        max = matrix[i, j];
                        row = i + 1; column = j + 1;
                    }
                }
            }
            Print(max);
            Print(row, column);
        }

        static void ex3()
        {
            char[][] words = new char[5][];
            TransWords(words, 5);
            PrintToRow(words, FindMaxColumn(words, 5));
        }
    }
}