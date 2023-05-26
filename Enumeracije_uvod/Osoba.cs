using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije_uvod
{
    internal class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Spol Spol { get; set; }
        private StrucnaSprema sprema;
        public StrucnaSprema Sprema
        {
            get
            {
                return sprema;
            }
            set
            {
                sprema = value;
            }
        }
        public Osoba(string ime, string prezime, Spol spol)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Spol = spol;
        }
    }
}
