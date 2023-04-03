using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable_pravokutnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite sirinu pravokutnika: ");
            double sirina = double.Parse(Console.ReadLine());
            Console.Write("Unesite visinu pravokutnika: ");
            double visina = double.Parse(Console.ReadLine());

            Console.WriteLine("Povrsina pravokutnika je: " + sirina * visina);
            Console.WriteLine("Opseg pravokutnika je: " + 2 *(sirina + visina));

            Console.WriteLine("Dijagonala je: " + Math.Sqrt(sirina * sirina + visina * visina));
        }
    }
}
