using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        // Назаров
        // Написать программу обмена значениями двух переменных:
        // а) с использованием третьей переменной;
        // б) *без использования третьей переменной.

        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            Console.WriteLine("Переменная а = {0}, переменная b = {1}", a, b);

            int c = b;
            b = a;
            a = c;
            Console.WriteLine("Теперь переменная а = {0}, переменная b = {1}", a, b);

            a = 12;
            b = 2;

            Console.WriteLine("Переменная а = {0}, переменная b = {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Теперь переменная а = {0}, переменная b = {1}", a, b);

        }
    }
}
