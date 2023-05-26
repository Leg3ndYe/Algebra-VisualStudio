using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifikator_pristupa_private
{

    class Korisnik
    {
        private string Ime;
        private string Adresa;
        private int Godine;

        private void IspisDetalja()
        {
            Console.WriteLine("Ime: " + Ime);
            Console.WriteLine("Adresa: " + Adresa);
            Console.WriteLine("Dob " + Godine);
        }

        public Korisnik(string ime, string adresa, int godine)
        {
            Ime = ime;
            Adresa = adresa;
            Godine = godine;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer modifikatora pristupa private: ");

            Korisnik k = new Korisnik("Nikola", "Osijek", 20);
            
        }
    }
}
