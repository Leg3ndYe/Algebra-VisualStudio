using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serijalizacija_dodatni_primjer
{
    [Serializable]
    class KorisnickiDetalji
    {
        public int ID { get; set; }
        public string ImePrezime { get; set; }
        public string Adresa { get; set; }
        public KorisnickiDetalji(int id, string ime_prezime, string prebivaliste)
        {
            ID = id;
            ImePrezime = ime_prezime;
            Adresa = prebivaliste;
        }

        public void DohvatiDetalje()
        {
            Console.WriteLine("Sifra korisnika: "+ID);
            Console.WriteLine("Ime i Prezime: "+ImePrezime);
            Console.WriteLine("Adresa: "+Adresa);
        }
    }
}
