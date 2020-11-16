using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    class Program
    {
        static string Tell(string n)
        {
            Console.Write(n);
            string s = Console.ReadLine();
            return s;
        }

        //  Назаров
        //  Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        //  а) используя склеивание;
        //  б) используя форматированный вывод;
	    //  в) используя вывод со знаком $.
        static void Main(string[] args)
        {
            string name = Tell("Введите ваше имя: ");
            string family = Tell("Введите вашу фамилию: ");
            string age = Tell("Введите ваш возраст: ");
            string height = Tell("Введите ваш рост: ");
            string weight = Tell("Введите ваш вес: ");

            Console.WriteLine("\nПривет, " + name + ". Теперь ты в базе всея интернета. Мы всё знаем о тебе. Фамилия: " + family + ", возраст: " + age + ", рост " + height + ", вес " + weight + "\nБольшой Брат следит за тобой");

            Console.WriteLine("\nФорматированный вывод:\nПривет, {0} {1}. Твой вес {2}, рост {3}, возраст {4}.", name, family, weight, height, age);

            Console.WriteLine($"\nЧерез доллар:\nПривет, {name} {family}. Твой вес {weight}, рост {height}, возраст {age}.");
        }
    }
}
