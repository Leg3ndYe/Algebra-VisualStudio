using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace switch_izracun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program za jednostavno racunanje s opcijama iz izbornika: ");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();

            int a, b, opcija;

            Console.Write("Unesite prvi broj: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Popis dostupnih opcija: ");
            Console.WriteLine("1 - Zbrajanje");
            Console.WriteLine("2 - Mnozenje");
            Console.WriteLine("3 - Oduzimanje");
            Console.WriteLine("4 - Dijeljenje");
            Console.WriteLine("5 - Ostatak prilikom dijeljenja");
            Console.WriteLine("6 - Izlaz");
            Console.Write("Odaberite opciju: ");
            opcija = Convert.ToInt32(Console.ReadLine());

            switch (opcija)
            {
                case 1:
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case 3:
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case 4:
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
                case 5:
                    Console.WriteLine($"{a} % {b} = {a % b}");
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Nepoznata opcija!");
                    break;
            }
        }
    }
}
