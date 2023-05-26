using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_abstraktne_klase
{
    public abstract class Zaposlenik
    {
        public int ID_Zaposlenika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Vrsta_Posla { get; set; }
        public string PunoIme() { return Ime + " " + Prezime; }
        public abstract decimal Placa();
    }
}
