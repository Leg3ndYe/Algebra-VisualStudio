using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_then_by
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polaznik[] ListaPolaznika =
            {
                    new Polaznik(){ ID = 1, ImePrezime = "Nikola Tesla", Starost = 74},
                    new Polaznik(){ ID = 2, ImePrezime = "Ivan Horvat", Starost = 27},
                    new Polaznik(){ ID = 3, ImePrezime = "Ana Knezevic", Starost = 18},
                    new Polaznik(){ ID = 4, ImePrezime = "Danijel Pobi", Starost = 34},
                    new Polaznik(){ ID = 5, ImePrezime = "Bill Gates", Starost = 76},
                    new Polaznik(){ ID = 6, ImePrezime = "Elon Musk", Starost = 53},
                    new Polaznik(){ ID = 7, ImePrezime = "Joza Manolic", Starost = 102},
                    new Polaznik(){ ID = 8, ImePrezime = "Rudjer Boskovic", Starost = 54}
            };

            Console.WriteLine("==============================================================");
            Console.WriteLine("LINQ ThenBy operator - uzlazno visestruko sortiranje");
            Console.WriteLine("==============================================================");

            var sortiraj_visestruko_uzlazno = ListaPolaznika.OrderBy(p => p.Starost).ThenBy(p => p.ImePrezime);

            foreach (var rez in sortiraj_visestruko_uzlazno)
            {
                Console.WriteLine(rez.ImePrezime + " " + rez.Starost);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==============================================================");
            Console.WriteLine("LINQ ThenBy operator - uzlazno visestruko sortiranje");
            Console.WriteLine("==============================================================");

            var sortiraj_visestruko_silazno = ListaPolaznika.OrderBy(x => x.ImePrezime).ThenByDescending(x => x.Starost);

            foreach (var rez in sortiraj_visestruko_silazno)
            {
                Console.WriteLine(rez.ImePrezime + " " + rez.Starost);
            }

        }
    }
    class Polaznik
    {
        public int ID { get; set; }
        public string ImePrezime { get; set; }
        public int Starost { get; set; }
    }
}
