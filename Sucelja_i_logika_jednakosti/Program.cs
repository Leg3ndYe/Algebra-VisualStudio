using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_i_logika_jednakosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sortirani = new SortedSet<Osoba>();
            var hashirani = new HashSet<Osoba>(new UpraviteljUsporedjivanjaOsoba());
            PopuniKolekciju(sortirani, hashirani);

            Console.WriteLine(sortirani.Count);
            Console.WriteLine(hashirani.Count);
        }
        private static void PopuniKolekciju(SortedSet<Osoba> sortirane_osobe, HashSet<Osoba> hashed_osobe)
        {
            Console.Write("Unesite koliko ljudi za unijeti: ");
            int broj = int.Parse(Console.ReadLine());

            while(broj>0)
            {
                try
                {
                    Console.Write("Unesite prvo ime, a zatim dob osobe nakon prvog razmaka:");
                    var podaci = Console.ReadLine().Split();
                    var ime = podaci[0];
                    var godine = int.Parse(podaci[1]);

                    sortirane_osobe.Add(new Osoba(ime, godine));
                    hashed_osobe.Add(new Osoba(ime, godine));

                    broj--;
                    Console.WriteLine();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
