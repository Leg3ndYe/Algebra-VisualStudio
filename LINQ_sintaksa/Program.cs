using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_sintaksa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polaznik[] listaPolaznika =
                new Polaznik[]
                {
                    new Polaznik(){ ID = 1, ImePrezime = "Nikola Tesla", Starost = 74},
                    new Polaznik(){ ID = 2, ImePrezime = "Ivan Horvat", Starost = 27},
                    new Polaznik(){ ID = 3, ImePrezime = "Ana Knezevic", Starost = 18},
                    new Polaznik(){ ID = 4, ImePrezime = "Danijel Pobi", Starost = 34},
                    new Polaznik(){ ID = 5, ImePrezime = "Bill Gates", Starost = 76},
                    new Polaznik(){ ID = 6, ImePrezime = "Elon Musk", Starost = 53},
                    new Polaznik(){ ID = 7, ImePrezime = "Joza Manolic", Starost = 102},
                    new Polaznik(){ ID = 8, ImePrezime = "Miroslav Skoro", Starost = 54}
                };

            Console.WriteLine("===================================================================================");
            Console.WriteLine("Zadatak: Pronaci polaznike izmedju 40 i 65 godina starosti i pohraniti u novi array");
            Console.WriteLine("===================================================================================");

            Polaznik[] polaznici = new Polaznik[10];

            int i = 0;
            foreach(Polaznik p in listaPolaznika)
            {
                if (p.Starost >= 40 && p.Starost <= 65)
                {
                    polaznici[i++] = p;
                }
            }

            for (int j = 0; j < polaznici.Length; j++)
            {
                if(polaznici.ElementAtOrDefault(j) != null)
                {
                    Console.WriteLine(polaznici[j].ID + ": " + polaznici[j].ImePrezime + ", " + polaznici[j].Starost);
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===================================================================================");
            Console.WriteLine("Zadatak: Gornji zadatak s LINQ upitom (method syntax)");
            Console.WriteLine("===================================================================================");

            polaznici = listaPolaznika.Where(p => p.Starost >= 40 && p.Starost <= 65).ToArray();

            for (int j = 0; j < polaznici.Length; j++)
            {
                if (polaznici.ElementAtOrDefault(j) != null)
                {
                    Console.WriteLine(polaznici[j].ID + ": " + polaznici[j].ImePrezime + ", " + polaznici[j].Starost);
                }
            }
            Console.WriteLine();
        }
    }
    class Polaznik
    {
        public int ID { get; set; }
        public string ImePrezime { get; set; }
        public int Starost { get; set; }

    }
}
