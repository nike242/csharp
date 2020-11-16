using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {

        // Назаров
        //  а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
        //  б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

        static double Distance(double x1, double x2, double y1, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
        static void Main(string[] args)
        {
            double x1 = 5;
            double x2 = 11;
            double y1 = 15;
            double y2 = 20;

            Console.WriteLine("{0:0.00}", Distance(x1, x2, y1, y2));

        }
    }
}
