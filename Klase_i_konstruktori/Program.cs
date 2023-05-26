using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_konstruktori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj = 0;
            int drugiBroj = broj;

            Osoba o = new Osoba();

            Osoba ob = new Osoba("Lukas", false);
            ob = null;

            Osoba o2 = new Osoba("Mirko");
            Osoba o3 = new Osoba("Nikola", "Tesla");
            Osoba o4 = new Osoba("Ujevic", true);

            Console.WriteLine(o.ImePrezime());
            Console.WriteLine(o2.ImePrezime());
            Console.WriteLine(o3.ImePrezime());
            Console.WriteLine(o4.ImePrezime());
        }
    }
}
