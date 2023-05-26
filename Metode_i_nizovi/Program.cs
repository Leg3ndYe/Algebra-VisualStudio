using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_i_nizovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer jednostavne metode s nizovima(stringovi)");
            Console.WriteLine();

            string[] podaci = new string[2];

            Console.Write("Unesite ime: ");
            podaci[0] = Console.ReadLine();
            Console.Write("Unesite prezime: ");
            podaci[1] = Console.ReadLine();

            Console.WriteLine();
            
            DobroDosli(podaci);
            Pozdrav();
        }

        static void Pozdrav()
        {
            Console.WriteLine("Zelimo vam ugodan dan!");
        }

        static void DobroDosli(string[] kolekcija) 
        {
            Console.WriteLine("Pozdrav " + kolekcija[0] + " " + kolekcija[1] + " :)");
        }
    }
}
