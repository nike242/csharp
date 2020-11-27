using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    // Назаров
    // а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
    // б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
    // в) Добавить диалог с использованием switch демонстрирующий работу класса.

    class Complex
    {
       public double a, b;
       
       public Complex(double re, double im)
        {
            a = re;
            b = im;
        }

        public override string ToString()
        {
            return $"{a} + {b}i";
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(
                re: c1.a + c2.a,
                im: c1.b + c2.b
                );
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(
                re: c1.a - c2.a,
                im: c1.b - c2.b
                );
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(
                re: c1.a * c2.a - c1.b * c2.b,
                im: c1.b * c2.a + c1.a * c2.b
                );
        }

    }

    class Program
    {
        static void Dialog(Complex z1, Complex z2)
        {
            Console.WriteLine("Выберите действие, введите умножение, сложение, или вычитание");
            string action = Console.ReadLine();

            switch (action)
            {
                case "умножение":
                    Console.WriteLine(z1 * z2);
                    break;
                case "сложение":
                    Console.WriteLine(z1 + z2);
                    break;
                case "вычитание":
                    Console.WriteLine(z1 - z2);
                    break;
                default:
                    Console.WriteLine("Вы ввели неизвестное выражение");
                    break;
            }



        }

        static void Main(string[] args)
        {
            Complex z1 = new Complex(1, 23);
            Complex z2 = new Complex(4, 212);
            Dialog(z1, z2);
        }
    }
}
