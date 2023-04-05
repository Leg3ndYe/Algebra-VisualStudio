using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_natjecanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hogwarts?");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            string ime, prezime, rezultat;
            double metloboj, crna_magija, alkemija, ukupno, postotak;

            Console.Write("Unesi ime ucenika: ");
            ime = Console.ReadLine();
            Console.Write("Unesi prezime ucenika: ");
            prezime = Console.ReadLine();

            Console.Write("Unesite broj bodova iz metloboja (0-100): ");
            metloboj = Convert.ToDouble(Console.ReadLine());
            Console.Write("Unesite broj bodova iz crne magije (0-100): ");
            crna_magija = Convert.ToDouble(Console.ReadLine());
            Console.Write("Unesite broj bodova iz alkemije (0-100): ");
            alkemija = Convert.ToDouble(Console.ReadLine());

            ukupno = metloboj + crna_magija + alkemija;
            postotak = ukupno / 3;

            if (postotak > 60) rezultat = "Gryffindor";
            else if (postotak >= 48) rezultat = "Hufflepuff";
            else if (postotak >= 36) rezultat = "Ravenclaw";
            else rezultat = "Slytherin";

            Console.WriteLine($"Ucenik {ime} {prezime} je ostvario sljedeci rezultat: ");
            Console.WriteLine($"Metloboj {metloboj} bodova.");
            Console.WriteLine($"Crna magija {crna_magija} bodova.");
            Console.WriteLine($"Alkemija {alkemija} bodova.");
            Console.WriteLine($"Ukupono bodova {ukupno}.");
            Console.WriteLine($"Ostvareno {postotak} posto.");
            Console.WriteLine($"Uceniku je dodijeljena {rezultat} kuca.");

        }
    }
}
