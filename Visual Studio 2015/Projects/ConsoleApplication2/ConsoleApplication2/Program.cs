﻿using System;
using System.Collections;
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
            for (int i = 0; i < d.GetLength(0); i++)
            {
                for (int j = 0; j < d.GetLength(1); j++)
                {
                    d[i, j] = 2 * d[i, j];
                }
            }

            int[,] c = Sub(Multiplcation(a, b), d);
            return c;
        }

        static string[] Reverse(string sentence)
        {
            string newword = "";
            int k = 0;
            string[] words = new string[sentence.Length];
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    newword = newword + sentence[i];
                }
                else { words[k] = newword + " "; newword = ""; k++; }
                if (i == sentence.Length - 1)
                {
                    words[k] = newword + " ";
                }

            }
            string[] finalsentence = new string[words.Length + 1];
            for (int i = 1; i < words.Length; i++)
            {
                finalsentence[i] = words[words.Length - i];
            }
            finalsentence[finalsentence.Length - 1] = words[0];


            return finalsentence;
        }
        static bool PrimaryRecusrsive(int n, int i)
        {
            if (i == n)
            {
                return true;
            }
            else if (n % i == 0)
            {
                return false;
            }
            return PrimaryRecusrsive(n, i + 1);
        }

        static string RemoveVowel(string word, int i)
        {
            if (i < word.Length)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'y')
                {
                    return RemoveVowel(word.Remove(i, 1), i);
                }
                else
                {
                    return RemoveVowel(word, i + 1);
                }
            }
            else
            {
                return word;
            }

        }

        static bool BinarySearch(int a, int b)
        {
            int[] tab = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int first = 0;
            int last = tab.Length - 1;
            if(a>tab[tab.Length -1] && b > tab[tab.Length - 1])
            {
                return false;
            }

            while (last > first)
            {
                int mid = first + (last - first) / 2;
                if (tab[mid] == a || tab[mid] == b || tab[mid] > a || tab[mid] < b)
                {
                    return true;
                }
                else if (tab[mid] < a)
                {
                    first = mid + 1;
                }
                else if (tab[mid] > b)
                {
                    last = mid - 1;
                }
            }
            return false;
        }

        static int [] AscendingNumbers(int [] tab)
        {
            int longestlength = 0;
            int start = 0;
            int startlongest = 0;
            int length = 0;
            for (int i = 1; i<tab.Length; i++)
            {
                length = i - start;
                if (tab[i] < tab[i - 1])
                {
                    if (longestlength < length)
                    {
                        longestlength = length;
                        startlongest = start;
                    }
                    start = i;
                }
                if (longestlength < length)
                {
                    longestlength = length;
                    startlongest = start;
                }
            }

            int[] result = new int[longestlength];
            for (int i = startlongest; i<(startlongest+longestlength); i++)
            {
                result[i-startlongest] = tab[i];
            }

            Console.WriteLine("longestlength : " + longestlength + "\nstartlongest : " + startlongest);
            return result;
        }
    




        static void Main(string[] args)
        {
            /*int[,] a = { { 1, 2 }, { 3, 4 } };
            int[,] b = { { 5, 6 }, { 7, 8 } };
            int[,] c = Operation(a, b);
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(0); j++)
                {
                    Console.Write(c[i, j]+" ");
                }
                Console.WriteLine();
            }*/
            /*string[] tab = Reverse("this is awesome");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]);
            }*/

            //Console.WriteLine(PrimaryRecusrsive(24,2));
            //Console.WriteLine(RemoveVowel("Bonjour", 0));

            Console.WriteLine(BinarySearch(10,11));
            /*int[] tab = { 1, 2, 3, 4,10 ,15, 18,23,30,89,90,1078, 14, 16, 7, 8, 9, 10, 11,12,13,14,15,16,17,1};
            int [] subsequence = AscendingNumbers(tab);
            for (int i =0; i <= subsequence.Length-1; i++)
            {
                Console.Write(subsequence[i] + " |");
            }*/
        }
    }
}
