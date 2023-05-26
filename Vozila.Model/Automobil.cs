using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Automobil:Vozilo
    {
        #region Privatni clanovi
        private string broj_sasije;
        private int ccm;
        #endregion

        #region Svojstva
        /// <summary>
        /// Svojstvo za rad s brojem sasije
        /// </summary>
        /// <exception cref="ArgumentException">Greska ukoliko nema 17 znakova kad postavljamo!</exception>
        public string Broj_sasije
        {
            get { return broj_sasije;}
            set
            {
                if (((string)value).Length != 17) throw new ArgumentException("Neispravan format broja sasije");
                broj_sasije = value;
            }
        }
        /// <summary>
        /// Svojstvo za rad s kubikazom motora
        /// </summary>
        /// <exception cref="ArgumentException">Ne smije biti negativna kubikaza!</exception>
        public int Ccm
        {
            get { return ccm; }
            set
            {
                if (value < 0) throw new ArgumentException("Kubikaza ne moze biti negativna.");
                ccm = value;
            }
        }
        #endregion

    }
}
