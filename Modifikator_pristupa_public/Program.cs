using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifikator_pristupa_public
{
    class Korisnik
    {
        public string Ime;
        public string Adresa;
        public int Godine;
        public void IspisDetalja()
        {
            Console.WriteLine("Ime : " + Ime);
            Console.WriteLine("Adresa stanovanja: " + Adresa);
            Console.WriteLine("Dob: " + Godine);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer modifikatora pristupa - public: ");

            Korisnik k = new Korisnik();

            k.Ime = "Nikola";
            k.Adresa = "Osijek";
            k.Godine = 20;

            k.IspisDetalja();

        }
    }
}
