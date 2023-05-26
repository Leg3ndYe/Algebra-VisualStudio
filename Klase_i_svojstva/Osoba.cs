using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_svojstva
{
    /// <summary>
    /// Klasa Osoba, koja nam predstavlja podatke svih osoba 
    /// u nasem sustavu.
    /// </summary>
    class Osoba
    {
        #region Svojstva
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private int starost;
        public int Starost
        {
            get { return starost; }
            set 
            {
                if(value > 0) starost = value;
                //else starost = 0;
                else
                {
                    throw new Exception("Starost mora biti veca od 0!!");
                }
            }
        }

        private string oib;
        /// <summary>
        /// OIB koji mora biti 11 znamenki
        /// Ako nije 11 znamenki, baca iznimku!
        /// </summary>
        /// <exception cref="Exception">
        /// Ukoliko OIB nije napisan po pravilima!
        /// </exception>
        public string OIB
        {
            get { return oib; }
            set
            {
                if(value.Length != 11)
                {
                    throw new Exception("Oib mora biti 11 znakova!!");
                }
                int broj;
                if(int.TryParse(value, out broj))
                {
                    throw new Exception("Moraju biti samo brojcane znamenke!");
                }
                oib = value;
            }
        }

        public string BojaKose { get; set; }
        public int BrojCipela { get; set; }
        #endregion
        #region Konstruktori
        public Osoba() { }
        /// <summary>
        /// Konstruktor klase Osoba
        /// </summary>
        /// <param name="Oib">Ocekujemo ispravno napisan OIB!</param>
        public Osoba(string Oib)
        {
            OIB = Oib;
            BrojCipela = 28;
        }
        #endregion
        #region Metode
        public void PromijeniBrojCipela(int broj)
        {
            BrojCipela = broj;
        }
        #endregion
    }
}
