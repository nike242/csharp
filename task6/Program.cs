using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        // Назаров
        // *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
        // Хорошим называется число, которое делится на сумму своих цифр. 
        // Реализовать подсчет времени выполнения программы, используя структуру DateTime.

        // В интернете есть более короткое решение, но нашёл я его уже после выполнения, не стал переделывать. Время выполнения в моём решении дольше, правда, чем там

        static bool CheckNice(double a)
        {
            double result = 0;
            int[] arr = a.ToString().ToCharArray().Select(x => x - '0').ToArray();

            for (int i = 0; i < arr.Length; i++) { result += arr[i]; }
            if (a % result == 0) return true; else return false;
        }
        static void NiceNumbers(double a, double max)
        {
            DateTime startMethod = DateTime.Now;
            int result = 0;
            while (a <= max)
            {
                if (CheckNice(a))
                {
                    result++;
                    Console.WriteLine("Число хорошее " + a);  
                }
                a++;

            }
            DateTime finishMethod = DateTime.Now;

            Console.WriteLine("Хороших чисел в диапазоне от 1 до {0}: {1}", max, result);
            Console.WriteLine("Потрачено секунд на выполнение метода: {0}", (finishMethod - startMethod).Seconds);
        }
        static void Main(string[] args)
        {
            double a = 1;
            double max = 1000000000;

            NiceNumbers(a, max);

        }
    }
}
