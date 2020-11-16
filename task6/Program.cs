using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    // Назаров
    // Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause)
    class Metods
    {
        static string Tell(string n)
        {
            Console.Write(n);
            string s = Console.ReadLine();
            return s;
        }

        static void Pause()
        {
            Console.ReadKey();
        }

        static void Pause(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static void Print(string msg, ConsoleColor foregroundcolor)
        {
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
