using Eksplicitna_ali_explicitna.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Eksplicitna_ali_explicitna.Models
{
    public class Gradjanin : IStanovnik, IOsoba
    {
        public Gradjanin(string ime_prezime) 
        {
            ImePrezime = ime_prezime;
        }
        public string ImePrezime { get; private set; }

        public int Godine { get; private set; }

        public string Drzava { get; private set; }

        string IOsoba.DohvatiImePrezime()
        {
            return this.ImePrezime;
        }
        string IStanovnik.DohvatiImePrezime()
        {
            return "Gdin/gdja " + ImePrezime;
        }
        public string DohvatiImePrezime()
        {
            return ImePrezime + " iz " + Drzava;
        }
    }
}
