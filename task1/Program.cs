using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        // Назаров
        // Написать метод, возвращающий минимальное из трех чисел.
        static int Min(int a, int b, int c)
        {
            int min;
            if (a <= b & a <= c)
                min = a;
            else if (b <= a & b <= c)
                min = b;
            else
                min = c;
            return min;
        }
        static void Main(string[] args)
        {
            int a = 9, b = -10, c = 27;
            Console.WriteLine(Min(a, b, c));
        }
    }
}
