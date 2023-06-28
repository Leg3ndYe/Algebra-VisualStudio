using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimni_tipovi_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Anonimni tipovi - jednostavni anonimni tip");
            Console.WriteLine("==========================================");

            var polaznik = new
            {
                ID = 1,
                Ime = "Marko",
                Prezime = "Marulic"
            };
            Console.WriteLine(polaznik.ID);
            Console.WriteLine(polaznik.Ime);
            Console.WriteLine(polaznik.Prezime);

            //polaznik.ID = 2;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Anonimni tipovi - ugnjezdjivanje");
            Console.WriteLine("==========================================");

            var novi_polaznik = new
            {
                Id = 2,
                Ime = "Lukas",
                Prezime = "Mazan",
                Adresa = new { Id = 1, Grad = "New York", Drzava = "USA" }
            };
            Console.WriteLine(novi_polaznik.Adresa.Grad);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Anonimni tipovi - polja anonimnih tipova");
            Console.WriteLine("==========================================");

            var polaznici = new[]
            {
                new {Id = 1, Ime = "Ana", Prezime = "Anic"},
                new {Id = 2, Ime = "Ivo", Prezime = "Ivic"},
                new {Id = 3, Ime = "Stipe", Prezime = "Stipic"}
            };

            foreach(var item in polaznici)
            {
                Console.WriteLine(item.Ime);
            }
        }
    }
}
