using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_racunske_operacije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            char op;

            Console.Write("Unesite prvi broj: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Unesite operaciju: ");
            op = Convert.ToChar(Console.ReadLine());

            //if (op == '+') Console.WriteLine($"{a} + {b} = {a + b}");
            //else if (op == '-') Console.WriteLine($"{a} - {b} = {a - b}");
            //else if (op == '*') Console.WriteLine($"{a} * {b} = {a * b}");
            //else if (op == '/') Console.WriteLine($"{a} / {b} = {a / b}");
            //else Console.WriteLine("Nemam pojma na koju operaciju mislis.");
           
            switch (op)
            {
                case '+': Console.WriteLine($"{a} + {b} = {a + b}"); break;
                case '-': Console.WriteLine($"{a} - {b} = {a - b}"); break;
                case '*': Console.WriteLine($"{a} * {b} = {a * b}"); break;
                case '/': Console.WriteLine($"{a} / {b} = {a / b}"); break;
                default: Console.WriteLine("Nemam pojma na koju operaciju mislis.");
                    break;
            }
        }
    }
}
