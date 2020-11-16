using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static string Tell(string n)
        {
            Console.Write(n);
            string s = Console.ReadLine();
            return s;
        }

        // Назаров
        // Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.

        static double Imt(double weight, double height)
        {
            double result = weight / (height * height);
            return result;
        }
        static void Main(string[] args)
        {
            string weight = Tell("Введите ваш вес: ");
            string height = Tell("Введите ваш рост: ");

            double weig = Convert.ToDouble(weight);
            double heig = Convert.ToDouble(height);

            Console.WriteLine("Ваш ИМТ: {0:0.##}", Imt(weig, heig));

        }
    }
}
