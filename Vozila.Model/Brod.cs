using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    enum Vrsta_broda
    {
        Gliser,
        Jedrilica,
        Katamaran,
        Tanker,
        Plivarica,
        Ribarica,
        Camac,
        Gumenjak,
        Nosac,
        Trajekt,
        Podmornica,
        Gajeta,
        Veslarica,
        Galija,
        Parobrod
    }
    public class Brod:Vozilo
    {
        #region Privatni_clanovi
        private decimal istisnina;
        private Vrsta_broda vrsta_broda;
        #endregion

        #region Svojstva
        public decimal Istisnina
        {
            get { return istisnina; }
            set
            {
                if ((decimal)value < 0) throw new ArgumentException("Istisnina ne moze biti negativna!");
                istisnina = value;
            }
        }
        public Vrsta_broda Vrsta_broda
        {
            get { return vrsta_broda; }
            set { vrsta_broda = value; }
        }
        #endregion

        #region Konstruktori
        public Brod() { }
        public Brod(string naziv, string boja, int snaga, decimal istisnina, Vrsta_broda vrsta_broda):base(naziv, boja, snaga)
        {
            Istisnina = istisnina;
            Vrsta_broda = vrsta_broda;
        }
        #endregion
    }
}
