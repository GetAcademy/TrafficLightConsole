using System;
using System.Text;

namespace TrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("┏━━┓");
            DrawLine(ConsoleColor.Red);
            DrawLine(ConsoleColor.Yellow);
            DrawLine(ConsoleColor.Green);
            Console.WriteLine("┗━━┛");
        }

        public static void DrawLine(ConsoleColor color)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("┃");
            Console.ForegroundColor = color;
            Console.Write("⚫");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("┃");
        }
    }
}
