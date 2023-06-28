using Sucelja_za_ferrari.Automobili;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_za_ferrari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string model = "559 GTO";
            Console.WriteLine("Unesite vozaca: ");
            var vozac = Console.ReadLine();

            var auto = new Ferrari(vozac, model);
            Console.WriteLine(auto);

            string nazivklase = typeof(Ferrari).Name;
            string nazivsucelja = typeof(IAutomobil).Name;
            Console.WriteLine($"{nazivklase} je klasa, a sucelje koje implementira je {nazivsucelja}.");
            Console.WriteLine();

            bool sucelje = typeof(IAutomobil).IsInterface;
            if(!sucelje)
            {
                throw new Exception("Nije stvoreno sucelje za automobile!");
            }
        }
    }
}
