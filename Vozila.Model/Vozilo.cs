using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    /// <summary>
    /// Klasa koja predstavlja vozilo
    /// </summary>
    public class Vozilo
    {
        #region Privatni clanovi
        private string naziv;
        private string boja;
        private int ks;
        #endregion

        #region Svojstva
        /// <summary>
        /// Svojstvo za pristup nazivu vozila
        /// </summary>
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        /// <summary>
        /// Svojstvo za pristup boji vozila
        /// </summary>
        public string Boja
        {
            get { return boja; }
            set { boja = value; }
        }
        /// <summary>
        /// Svojstvo za pristup konjskoj snazi vozila
        /// </summary>
        /// <exception cref="ArgumentException">Iznimka ukoliko se pokusa postaviti negativna vrijednost!</exception>
        public int Ks
        {
            get { return ks; }
            set 
            {
                if (value < 0) throw new ArgumentException("Snaga ne smije biti negativna");
                else ks = value;
            }
        }
        #endregion

        #region Konstruktori
        public Vozilo() { }
        public Vozilo(string naziv, string boja, int ks)
        {
            Naziv = naziv;
            Boja = boja;
            Ks = ks;
        }
        #endregion

        #region Metode
        public decimal KSuKW()
        {
            return Ks * (decimal)0.736;
        }

        public override string ToString()
        {
            return string.Format("Vozilo: {0}, {1} boje i {3} KS snage", naziv, boja, ks);
        }
        #endregion
    }
}
