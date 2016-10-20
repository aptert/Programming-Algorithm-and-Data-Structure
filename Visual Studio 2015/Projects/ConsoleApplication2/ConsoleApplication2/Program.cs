using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    class Program
    {
        static int PerfectSquare(int n)
        {
            int square = 1;
            for (int i = 0; i <= n; i++)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    square = i;
                }
            }
            return square;
        }

        static int[,] Add(int[,] a, int[,] b)
        {
            int dimension = a.GetLength(0);
            int[,] c = new int[dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            return c;
        }

        static int[,] Sub(int[,] a, int[,] b)
        {
            int dimension = a.GetLength(0);
            int[,] c = new int[dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    c[i, j] = a[i, j] - b[i, j];
                }
            }
            return c;
        }
        static int[,] Multiplcation(int[,] a, int[,] b)
        {
            int dimension = a.GetLength(0); //Matrices are the same size and they are square
            int[,] c = new int[dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    int k = 0;
                    while (k < dimension)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                        k++;
                    }
                }
            }
            return c;
        }

        static int[,] Operation(int[,] a, int[,] b)
        {
            int dimension = a.GetLength(0);
            int[,] d = Add(a, b);
            for (int i = 0; i<d.GetLength(0); i++)
            {
                for (int j = 0; j < d.GetLength(1); j++)
                {
                    d[i, j] = 2 * d[i, j];
                }
            }
            
            int [, ]c = Sub(Multiplcation(a, b),d);
            return c;
        }

        static string Reverse(string sentence)
        {
            string [] words = null;
            for (int i = 0; i<sentence.Length; i++)
            {
               
            }
        }


        static void Main(string[] args)
        {
            int[,] a = { { 1, 2 }, { 3, 4 } };
            int[,] b = { { 5, 6 }, { 7, 8 } };
            int[,] c = Operation(a, b);
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(0); j++)
                {
                    Console.Write(c[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
