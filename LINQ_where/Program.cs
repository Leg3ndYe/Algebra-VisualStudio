using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_where
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polaznik[] popisPolaznika =
            {
                new Polaznik(){ ID = 1, ImePrezime = "Nikola Tesla", Starost = 74},
                new Polaznik(){ ID = 2, ImePrezime = "Ivan Horvat", Starost = 27},
                new Polaznik(){ ID = 3, ImePrezime = "Ana Knezevic", Starost = 18},
                new Polaznik(){ ID = 4, ImePrezime = "Danijel Pobi", Starost = 38},
                new Polaznik(){ ID = 5, ImePrezime = "Bill Gates", Starost = 76},
                new Polaznik(){ ID = 6, ImePrezime = "Elon Musk", Starost = 53},
                new Polaznik(){ ID = 7, ImePrezime = "Joza Manolic", Starost = 102},
                new Polaznik(){ ID = 8, ImePrezime = "Miroslav Skoro", Starost = 54}
            };

            Console.WriteLine("===========================================================");
            Console.WriteLine("LINQ Where operator - Query Syntax stil: ");
            Console.WriteLine("===========================================================");

            var filtriran_rezultat = from p in popisPolaznika
                                     where p.Starost > 40 && p.Starost < 60
                                     select p.ImePrezime;

            foreach(var ip in filtriran_rezultat)
            {
                Console.WriteLine(ip);
            }

            Console.WriteLine("===========================================================");
            Console.WriteLine("LINQ Where operator - Funkcijski tip delegata sa anonimnom metodom: ");
            Console.WriteLine("===========================================================");

            Func<Polaznik, bool> jeURasponu = delegate (Polaznik p)
            {
                return p.Starost > 60 && p.Starost < 100;
            };

            var filtriraj_s_delegtom = from p in popisPolaznika
                                       where jeURasponu(p)
                                       select p.ImePrezime;

            foreach(var ip in filtriraj_s_delegtom)
            {
                Console.WriteLine(ip);
            }

            Console.WriteLine("===========================================================");
            Console.WriteLine("LINQ Where operator - S vanjskom metodom: ");
            Console.WriteLine("===========================================================");

            var filtriraj_s_metodom = from p in popisPolaznika
                                    where ProvjeriJeLiMladic(p)
                                    select p.ImePrezime;

            foreach(var ip in filtriraj_s_metodom)
            {
                Console.WriteLine(ip);
            }

            Console.WriteLine("===========================================================");
            Console.WriteLine("LINQ Where operator - Method Syntax stil: ");
            Console.WriteLine("===========================================================");

            var filtriraj_method_syntax = popisPolaznika.Where(x => x.Starost > 30 && x.Starost < 50);

            foreach(var rez in filtriraj_method_syntax)
            {
                Console.WriteLine(rez.ImePrezime);
            }

            Console.WriteLine("===========================================================");
            Console.WriteLine("LINQ Where operator - Method Syntax stil s uvjetom: ");
            Console.WriteLine("===========================================================");

            var filtriraj_method_syntax_s_uvjetom = popisPolaznika.Where((p, i) =>
            {
                if(i % 2 == 0)
                {
                    return true;
                }
                return false;

            });

            foreach(var r in filtriraj_method_syntax_s_uvjetom)
            {
                Console.WriteLine(r.ImePrezime);
            }

            Console.WriteLine("===========================================================");
            Console.WriteLine("LINQ Where operator - Visestruki where: ");
            Console.WriteLine("===========================================================");

            var filtriraj_visestruki1 = from p in popisPolaznika
                                        where p.Starost > 18
                                        where p.Starost < 50
                                        select p.ImePrezime;

            foreach(var rez in filtriraj_visestruki1)
            {
                Console.WriteLine(rez);
            }

            var filtriraj_visestruki2 = popisPolaznika.Where(p => p.Starost > 18).Where(p => p.Starost < 50);

            foreach(var rez in filtriraj_visestruki2)
            {
                Console.WriteLine(rez.ImePrezime);
            }
        }

        public static bool ProvjeriJeLiMladic(Polaznik p)
        {
            return p.Starost > 15 && p.Starost < 35;
        }
    }
    class Polaznik
    {
        public int ID { get; set; }
        public string ImePrezime { get; set; }
        public int Starost { get; set; }
    }
}
