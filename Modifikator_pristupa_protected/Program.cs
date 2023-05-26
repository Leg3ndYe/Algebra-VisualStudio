using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifikator_pristupa_protected
{
    class Korisnik
    {
        protected string Ime;
        protected string Adresa;
        protected int Godine;

        protected void IspisDetalja()
        {
            Console.WriteLine("Ime: " + Ime);
            Console.WriteLine("Adresa: " + Adresa);
            Console.WriteLine("Dob: " + Godine);
        }
    }


    internal class Program:Korisnik
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer modifikatora pristupa protected: ");

            Korisnik k = new Korisnik();

            //k.Ime = "Ana";
            //k.Adresa = "Zagreb";
            //k.Godine = 30;
            //k.IspisDetalja();

            Program p = new Program();
            p.Ime = "Ivana";
            p.Adresa = "Rijeka";
            p.Godine = 33;
            p.IspisDetalja();

        }
    }
}
