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
            for(int i = 0; i <= n; i++)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    square = i;
                }
            }
            return square;
        }
        static void Main(string[] args)
        {
            Console.Write(PerfectSquare(78));
        }
    }
}
