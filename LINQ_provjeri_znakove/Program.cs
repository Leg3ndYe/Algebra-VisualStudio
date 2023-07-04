using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_provjeri_znakove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst;

            Console.WriteLine("Unesite neki tekst: ");
            tekst = Console.ReadLine();

            var ucestalost_znakova = from x in tekst
                                     group x by x into y
                                     select y;

            Console.WriteLine("Ucestalost znakova: ");
            foreach (var stavka in ucestalost_znakova)
            {
                Console.WriteLine("Znak " + stavka.Key + ": " + stavka.Count());
            }
            Console.WriteLine();
        }
    }
}
