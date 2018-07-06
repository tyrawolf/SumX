using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumx
{
    class Program
    {
        static int sumX(int x, int n)
        {
            // your code here
            int j = 0;
            if (x > 0)
            {
                for (int i = x; i <= n; i = i + x)
                {
                    j = j + i;
                }
            }
            else if (x < 0)
            {
                for (int i = x; i >= n; i = i + x)
                {
                    j = j + i;
                }
            }
            else
            {
                return 0;
            }

            return j;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("sumX(3, 10): " + (sumX(3, 10) == 18));
            Console.WriteLine("sumX(1, 10): " + (sumX(1, 10) == 55));
            Console.WriteLine("sumX(0, 10): " + (sumX(0, 10) == 0));
            Console.WriteLine("sumX(-1, 10): " + (sumX(-1, 10) == 0));
            Console.WriteLine("sumX(-1, -10): " + (sumX(-1, -10) == -55));
            Console.WriteLine("sumX(-2, -10): "+(sumX(-2,-10) == -30));
        }
    }
}