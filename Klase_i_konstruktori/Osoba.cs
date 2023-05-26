using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_konstruktori
{
    class Osoba
    {
        public string Ime;
        public string Prezime;
        public int? Starost;

        public Osoba() 
        {
            if(Starost.HasValue)
            {

            }
            else
            {
                Starost = 0;
            }
        }
        public Osoba (string ime)
        {
            Ime = ime;
        }
        public Osoba (string ime, string prezime) :this(ime)
        {
            Prezime = prezime;
        }
        public Osoba(string ime, string prezime, int? starost) : this(ime, prezime)
        {
            Starost = starost;
        }
        public Osoba(string naziv, bool prezime)
        {
            if(prezime)
            {
                Prezime = naziv;
            }
            else
            {
                Ime = naziv;
            }
        }

        public string ImePrezime()
        {
            return Ime + " " + Prezime;
        }
    }
}
