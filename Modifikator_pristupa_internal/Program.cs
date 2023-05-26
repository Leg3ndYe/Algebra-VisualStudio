using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modifikator_pristupa_internal
{
    class Korisnik
    {
        internal string Ime;
        internal string Adresa;
        internal int Godine;

        internal void IspisDetalja()
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
            Console.WriteLine("Primjer modifikatora pristupa internal: ");

            Korisnik k = new Korisnik();
            k.Ime = "Marko";
            k.Adresa = "Pula";
            k.Godine = 5;
            k.IspisDetalja();

        }
    }
}
