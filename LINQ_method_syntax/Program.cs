using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_method_syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>() { 13, 5, 6, 1, 2, 3, 4, 8, 69, 74, 31, 23 };

            IEnumerable<int> moji_brojevi = brojevi.Where(x => x < 7 || x > 22);

            foreach (var broj in brojevi)
            {
                Console.Write(broj + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            List<string> kucni_ljubimci = new List<string>()
            {
                "Boa Constrictor imperator",
                "Kukurzna zmija",
                "Kraljevski piton",
                "L. Parahybana tarantula",
                "Pas",
                "Ribice"
            };

            var rezultat_pretrage = kucni_ljubimci.Where(x => x.Contains("as"));

            foreach (var ljubimac in rezultat_pretrage)
            {
                Console.WriteLine(ljubimac);
            }
            Console.WriteLine();

        }
    }
}
