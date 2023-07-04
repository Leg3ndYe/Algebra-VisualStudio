using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_order_by
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

            Console.WriteLine("=============================================================");
            Console.WriteLine("LINQ OrderBy operator - sortriranje uzlazno");
            Console.WriteLine("=============================================================");

            var sortiraj_uzlazno = from p in ListaPolaznika
                                   orderby p.ImePrezime
                                   select p;

            foreach (var rez in sortiraj_uzlazno)
            {
                Console.WriteLine(rez.ImePrezime);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=============================================================");
            Console.WriteLine("LINQ OrderBy operator - sortriranje silazno");
            Console.WriteLine("=============================================================");

            var sortiraj_silazno = from p in ListaPolaznika
                                   orderby p.ImePrezime descending
                                   select p;

            foreach (var rez in sortiraj_silazno)
            {
                Console.WriteLine(rez.ImePrezime);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=============================================================");
            Console.WriteLine("LINQ OrderBy operator - sortriranje uzlazno, method syntax");
            Console.WriteLine("=============================================================");

            var sortiraj_uzazno_method = ListaPolaznika.OrderBy(p => p.ImePrezime);

            foreach(var rez in sortiraj_uzazno_method)
            {
                Console.WriteLine(rez.ImePrezime);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=============================================================");
            Console.WriteLine("LINQ OrderBy operator - sortriranje silazno, method syntax");
            Console.WriteLine("=============================================================");

            var sortiraj_silazno_method = ListaPolaznika.OrderByDescending(p => p.ImePrezime);

            foreach(var rez in sortiraj_silazno_method)
            {
                Console.WriteLine(rez.ImePrezime);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=============================================================");
            Console.WriteLine("LINQ OrderBy operator - sortriranje visestruki kriteriji");
            Console.WriteLine("=============================================================");

            var sortiraj_visestruki_kriteriji = from p in ListaPolaznika
                                                orderby p.Starost, p.ImePrezime
                                                select new {p.Starost, p.ImePrezime};

            foreach(var rez in sortiraj_visestruki_kriteriji)
            {
                Console.WriteLine(rez);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=============================================================");
            Console.WriteLine("LINQ OrderBy operator - sortriranje visestruki kriteriji method");
            Console.WriteLine("=============================================================");

            var sortiraj_visestruki_kriterij_method = ListaPolaznika.OrderBy(p => p.Starost).OrderBy(p => p.ImePrezime); // WRONG {ORDER BY} replace by {THEN BY}

            foreach (var rez in sortiraj_visestruki_kriterij_method)
            {
                Console.WriteLine("Ima " + rez.Starost + " godina, Ime: " + rez.ImePrezime);
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
