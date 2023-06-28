using Eksplicitna_ali_explicitna.Models;
using Eksplicitna_ali_explicitna.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksplicitna_ali_explicitna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintajImenaSTypeCasting();
            PrintajImenaSDrugacijimSuceljima();
        }
        private static void PrintajImenaSTypeCasting()
        {
            Console.Write("Unesite ime i prezime: ");
            var ime_prezime = Console.ReadLine().Split();

            while (ime_prezime[0] != "kraj")
            {
                var osoba = new Gradjanin(ime_prezime[0]);
                Console.WriteLine(osoba.DohvatiImePrezime());
                Console.WriteLine(((IOsoba)osoba).DohvatiImePrezime());
                Console.WriteLine(((IStanovnik)osoba).DohvatiImePrezime());

                Console.WriteLine();
                Console.WriteLine("Unesite ime i prezime: ");
                ime_prezime = Console.ReadLine().Split();
            }
        }
        private static void PrintajImenaSDrugacijimSuceljima()
        {
            Console.Write("Unesite ime i prezime: ");
            var ime_prezime = Console.ReadLine().Split();

            while (ime_prezime[0] != "kraj")
            {
                Gradjanin g = new Gradjanin(ime_prezime[0]);
                IOsoba o = new Gradjanin(ime_prezime[0]);
                IStanovnik s = new Gradjanin(ime_prezime[0]);

                Console.WriteLine(g.DohvatiImePrezime());
                Console.WriteLine(o.DohvatiImePrezime());
                Console.WriteLine(s.DohvatiImePrezime());
            }
        }
    }
}
