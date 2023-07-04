using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> stringLista1 = new List<string>()
            {
                "Jedan",
                "Dva",
                "Tri",
                "Cetiri"
            };

            IList<string> stringLista2 = new List<string>()
            {
                "Jedan",
                "Dva",
                "Pet",
                "Sest"
            };

            Console.WriteLine("===========================================================");
            Console.WriteLine("LINQ Join - samo podudarne vrijednosti");
            Console.WriteLine("===========================================================");

            var podudarne_vrijednosti = stringLista1.Join(stringLista2, str1 => str1, str2 => str2, (str1, str2) => str1);

            foreach(var rez in podudarne_vrijednosti)
            {
                Console.WriteLine(rez);
            }

            Console.WriteLine();
            Console.WriteLine();

            List <Polaznik> ListaPolaznika = new List<Polaznik>()
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

            Console.WriteLine("===========================================================");
            Console.WriteLine("LINQ Join - join s razlicitim klasama - method syntax");
            Console.WriteLine("===========================================================");

            var ms_inner_join = ListaPolaznika.Join(
                ListaTecajeva,
                polaznik => polaznik.TecajID,
                tecaj => tecaj.ID,
                (polaznik, tecaj) => new
                {
                    ImePrezimePolaznik = polaznik.ImePrezime,
                    NazivTecaja = tecaj.Naziv
                }
            );

            foreach(var rez in ms_inner_join)
            {
                Console.WriteLine(rez);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===========================================================");
            Console.WriteLine("LINQ Join - join s razlicitim klasama - query syntax");
            Console.WriteLine("===========================================================");

            var qs_inner_join = from p in ListaPolaznika
                                join t in ListaTecajeva
                                on p.TecajID equals t.ID
                                select new
                                {
                                    ImePrezimePolaznik = p.ImePrezime,
                                    NazivTecaja = t.Naziv
                                };

            foreach (var rez in qs_inner_join)
            {
                Console.WriteLine(rez);
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
