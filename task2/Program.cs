using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        // Назаров
        // Написать метод подсчета количества цифр числа
        static int Numbers(int a)
        {
            return a.ToString().Length;
        }
        static void Main(string[] args)
        {
            int n = 1232154512;
            Console.WriteLine(Numbers(n));
        }
    }
}
