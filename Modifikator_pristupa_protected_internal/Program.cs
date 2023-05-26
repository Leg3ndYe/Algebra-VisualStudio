using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifikator_pristupa_protected_internal
{
    class Korisnik
    {
        protected internal string Ime;
        protected internal string Adresa;
        protected internal int Godine;

        protected internal void IspisDetalja()
        {
            Console.WriteLine("Ime: " + Ime);
            Console.WriteLine("Adresa: " + Adresa);
            Console.WriteLine("Dob " + Godine);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer modifikatora pristupa protected internal");

            Korisnik k = new Korisnik();
            k.Ime = "Mirko";
            k.Adresa = "Zadar";
            k.Godine = 55;
            k.IspisDetalja();
        }
    }
}
