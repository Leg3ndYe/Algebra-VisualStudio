using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer jednostavne klase i instanciranje objekata: ");
            Console.WriteLine();

            Osoba osoba = new Osoba();
            osoba.Ime = "Nikola";
            osoba.Prezime = "Tesla";
            osoba.Starost = 33;

            Osoba osoba2 = new Osoba();
            osoba2.Ime = "Marko";
            osoba2.Prezime = "Marulic";
            osoba2.Starost = 40;

            Console.WriteLine($"{osoba.Ime} {osoba.Prezime}");
            Console.WriteLine($"{osoba2.ImePrezime()}");
            Console.WriteLine(Osoba.BrojOsoba);
        }
    }

    class Osoba
    {
        public static int BrojOsoba = 0;



        public string Ime;
        public string Prezime;
        public int Starost;

        public Osoba()
        {
            BrojOsoba++;
        }

        public string ImePrezime()
        {
            return Ime + " " + Prezime;
        }
    }
}
