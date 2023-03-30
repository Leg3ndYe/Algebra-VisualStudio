using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvaAplikacija
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ColorChanger(ConsoleColor.Red, ConsoleColor.Yellow);
            Console.Clear();
            Console.WriteLine("Hello World!");
            ColorChanger(ConsoleColor.Blue, ConsoleColor.Red);
            Console.WriteLine("My name is");

            Console.ReadKey();
        }
        public static void ColorChanger(ConsoleColor background, ConsoleColor foreground)
        {
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }
    }
}
