using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifikator_pristupa_private_protected
{
    class Korisnik
    {
        private protected string Ime;
        private protected string Adresa;
        private protected int Godine;

        private protected void IspisDetalja()
        {
            Console.WriteLine("Ime: " + Ime);
            Console.WriteLine("Adresa: " + Adresa);
            Console.WriteLine("Dob " + Godine);
        }
    }


    internal class Program : Korisnik
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer modifikatora pristupa private-protected: ");

            Korisnik k = new Korisnik();
            //k.Ime = "Andrej";
            //k.Adresa = "Split";
            //k.Godine = 34;
            //k.IspisDetalja();

            Program program = new Program();
            program.Ime = "Calculator";
            program.Adresa = "Doma";
            program.Godine = 30;
            program.IspisDetalja();


        }
    }
}
