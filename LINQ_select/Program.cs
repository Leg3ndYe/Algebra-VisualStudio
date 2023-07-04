using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LINQ_select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Polaznik> ListaPolaznika = new List<Polaznik>()
            {
                    new Polaznik(){ ID = 1, ImePrezime = "Nikola Tesla", Starost = 74},
                    new Polaznik(){ ID = 2, ImePrezime = "Ivan Horvat", Starost = 27},
                    new Polaznik(){ ID = 3, ImePrezime = "Ana Knezevic", Starost = 18},
                    new Polaznik(){ ID = 4, ImePrezime = "Danijel Pobi", Starost = 34},
                    new Polaznik(){ ID = 5, ImePrezime = "Bill Gates", Starost = 76},
                    new Polaznik(){ ID = 6, ImePrezime = "Elon Musk", Starost = 53},
                    new Polaznik(){ ID = 7, ImePrezime = "Joza Manolic", Starost = 102},
                    new Polaznik(){ ID = 8, ImePrezime = "Rocky Bolboa", Starost = 54}
            };

            Console.WriteLine("==========================================================");
            Console.WriteLine("LINQ select - samo ime i prezime - query sintaks");
            Console.WriteLine("==========================================================");

            var qs_samo_ime_prezime = from p in ListaPolaznika
                                   select p.ImePrezime;

            foreach(var rez in qs_samo_ime_prezime)
            {
                Console.WriteLine("Polaznik je " + rez);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==========================================================");
            Console.WriteLine("LINQ select - sa anonimnim tipom rezultata - query sintaks");
            Console.WriteLine("==========================================================");

            var qs_anonimni_tip = from p in ListaPolaznika
                                  select new
                                  {
                                      Polaznik = p.ImePrezime,
                                      Godine = p.Starost
                                  };

            foreach(var rez in qs_anonimni_tip)
            {
                Console.WriteLine("Polaznik je " + rez.Polaznik + " i ima: " + rez.Godine + " godina");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==========================================================");
            Console.WriteLine("LINQ select - sa anonimnim tipom rezultata - method sintaks");
            Console.WriteLine("==========================================================");

            var ms_anonimni_tip = ListaPolaznika.Select(p => new
            {
                Polaznik = p.ImePrezime,
                Godine = p.Starost
            });

            foreach (var rez in ms_anonimni_tip)
            {
                Console.WriteLine("Polaznik je " + rez.Polaznik + " i ima: " + rez.Godine + " godina");
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
