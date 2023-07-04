using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Group_i_lookup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polaznik[] ListaPolaznika =
            {
                    new Polaznik(){ ID = 1, ImePrezime = "Nikola Tesla", Starost = 13},
                    new Polaznik(){ ID = 2, ImePrezime = "Ivan Horvat", Starost = 27},
                    new Polaznik(){ ID = 3, ImePrezime = "Ana Knezevic", Starost = 13},
                    new Polaznik(){ ID = 4, ImePrezime = "Danijel Pobi", Starost = 33},
                    new Polaznik(){ ID = 5, ImePrezime = "Bill Gates", Starost = 33},
                    new Polaznik(){ ID = 6, ImePrezime = "Elon Musk", Starost = 25},
                    new Polaznik(){ ID = 7, ImePrezime = "Joza Manolic", Starost = 25},
                    new Polaznik(){ ID = 8, ImePrezime = "Rudjer Boskovic", Starost = 21}
            };

            Console.WriteLine("================================================");
            Console.WriteLine("LINQ GroupBy - grupiranje po starosti");
            Console.WriteLine("================================================");

            var grupira_po_starosti = from p in ListaPolaznika
                                      group p by p.Starost;

            foreach (var grupa_starosti in grupira_po_starosti)
            {
                Console.WriteLine("Grupa starosti: " + grupa_starosti.Key);
                foreach(var p in grupa_starosti)
                {
                    Console.WriteLine("Ime i Prezime polaznika: " + p.ImePrezime);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine("LINQ GroupBy - grupiranje po starosti method syntax");
            Console.WriteLine("================================================");

            var grupiraj_po_starosti_method_syntax = ListaPolaznika.GroupBy(p => p.Starost);

            foreach (var grupa_starosti in grupiraj_po_starosti_method_syntax)
            {
                Console.WriteLine("Grupa starosti: " + grupa_starosti.Key);
                foreach (var p in grupa_starosti)
                {
                    Console.WriteLine("Ime i Prezime polaznika: " + p.ImePrezime);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine("LINQ ToLookup - grupiranje po starosti method syntax");
            Console.WriteLine("================================================");

            var grupiraj_s_lookup = ListaPolaznika.ToLookup(p => p.Starost);

            foreach (var grupa_starosti in grupiraj_s_lookup)
            {
                Console.WriteLine("Grupa starosti: " + grupa_starosti.Key);
                foreach (var p in grupa_starosti)
                {
                    Console.WriteLine("Ime i Prezime polaznika: " + p.ImePrezime);
                }
                Console.WriteLine();
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
