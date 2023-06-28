using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_i_polja
{
    internal class Program
    {
        class Osoba
        {
            public string Ime { get; set; }
        }
        static void Main(string[] args)
        {
            int[] brojevi = { 1, 2, 4, 5, 6, 7, 10, 13, 16, 17 };

            int[] parni = brojevi.Where(x => x % 2 == 0).ToArray();
            int[] neparni = brojevi.Where(x => x % 2 != 0).ToArray();

            List<Osoba> list = new List<Osoba>
            {
                new Osoba {Ime = "Marko"},
                new Osoba {Ime = "Ana"},
                new Osoba {Ime = "Ivana"}
            };

            var ime_s_a = list.Where(ime => ime.Ime.StartsWith("A")).ToList();

        }
    }
}
