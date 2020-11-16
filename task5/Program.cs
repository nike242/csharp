using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        // Назаров
        //  а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //  б) *Сделать задание, только вывод организовать в центре экрана.
        //  в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

        static string Tell(string n)
        {
            Console.Write(n);
            string s = Console.ReadLine();
            return s;
        }

        static string Info(string name, string family, string city)
        {
            return $"{name} {family}, {city}";
        }

        static void Main(string[] args)
        {
            string name = Tell("Введите ваше имя: ");
            string family = Tell("Введите вашу фамилию: ");
            string city = Tell("Введите ваш город проживания: ");

            Console.WriteLine(Info(name, family, city));

            double width = Console.WindowWidth;
            double padding = width / 2 + Info(name, family, city).Length / 2;
            Console.WriteLine("{0," + padding + "}", Info(name, family, city));
        }
    }
}
