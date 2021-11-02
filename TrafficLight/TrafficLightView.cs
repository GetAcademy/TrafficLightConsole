using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    class TrafficLightView
    {
        static void Mainx(string[] args)
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
