using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int Fact(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * Fact(number - 1);

        }
        static void ex1(int [] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + "|");
            }
            Console.WriteLine();
            Random shuffle = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                int nextindex = shuffle.Next(tab.Length);
                int tmp = tab[i];
                tab[i] = tab[nextindex];
                tab[nextindex] = tmp;
            }
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + "|");
            }

        }
        static int ex2(int number)
        {
            Console.WriteLine(Fact(number));
            int count = 0;
            int a = Fact(number);
            while (a % 5 == 0)
            {
                a = a / 5;
                count++;
            }
            return count; 
        }
        //static int exDate(int day, int month, int year)

        static int Alien(int X, int Y)
        {
            int[] tab = new int [32];
            tab[0] = 1;
            for (int i = 1; i<tab.Length - 1; i++)
            {
                if(i-1 != 5)
                {
                    tab[i] = 1;
                }

                else
                {
                    tab[i] = X * tab[i - Y];
                }

                
                Console.Write( tab[i] + "|");
            }


            return tab[32];
        }
        
        static void Main(string[] args)
        {
            int [] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //ex1(tab);
            Console.WriteLine("\n"+Alien(3,5));
            
        }
    }
}
