using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_group_join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Polaznik> ListaPolaznika = new List<Polaznik>()
            {
                new Polaznik(){ ID=1, ImePrezime="Nikola Tesla", TecajID=1},
                new Polaznik(){ ID=2, ImePrezime="Ivan Horvat", TecajID=2},
                new Polaznik(){ ID=3, ImePrezime="Ana Knežević", TecajID=2},
                new Polaznik(){ ID=4, ImePrezime="Ivana Brlić-Mažuranić", TecajID=1},
                new Polaznik(){ ID=5, ImePrezime="Ruđer Bošković", TecajID=3},
                new Polaznik(){ ID=6, ImePrezime="Bill Gates", TecajID=3},
                new Polaznik(){ ID=7, ImePrezime="Elon Musk", TecajID=1},
                new Polaznik(){ ID=8, ImePrezime="Joža Manolić"}
            };

            List<Tecaj> ListaTecajeva = new List<Tecaj>()
            {
                new Tecaj(){ ID=1, Naziv = "ASP.NET MVC programer"},
                new Tecaj(){ ID=2, Naziv = "MS SQL Server Administrator"},
                new Tecaj(){ ID = 3, Naziv = "Backend developer .NET"}
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("LINQ GroupJoin - Method Syntax");
            Console.WriteLine("==================================================");

            var ms_group_join = ListaTecajeva.GroupJoin(
                ListaPolaznika,
                tecaj => tecaj.ID,
                polaznik => polaznik.TecajID,
                (tecaj, grupaPolaznika) => new
                {
                    Polaznici = grupaPolaznika,
                    NazivTecaja = tecaj.Naziv
                });

            foreach(var stavka in ms_group_join)
            {
                Console.WriteLine(stavka.NazivTecaja);
                foreach(var polaznik in stavka.Polaznici)
                {
                    Console.WriteLine(polaznik.ImePrezime);
                }
                Console.WriteLine();
            }

            Console.WriteLine("==================================================");
            Console.WriteLine("LINQ GroupJoin - Query Syntax");
            Console.WriteLine("==================================================");

            var qs_group_join = from tecaj in ListaTecajeva
                                join polaznik in ListaPolaznika
                                on tecaj.ID equals polaznik.TecajID
                                into grupaPolaznika select new
                                {
                                    Polaznici = grupaPolaznika,
                                    NazivTecaja = tecaj.Naziv
                                };

            foreach (var stavka in qs_group_join)
            {
                Console.WriteLine(stavka.NazivTecaja);
                foreach (var polaznik in stavka.Polaznici)
                {
                    Console.WriteLine(polaznik.ImePrezime);
                }
                Console.WriteLine();
            }
        }
    }

    public class Polaznik
    {
        public int ID { get; set; }
        public string ImePrezime { get; set; }
        public int TecajID { get; set; }
    }

    public class Tecaj
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
    }
}
