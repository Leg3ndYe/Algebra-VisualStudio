using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_zivotinja
{
    abstract class Zivotinja
    {
        #region Privatni Clanovi
        private string naziv;
        private int godine;
        private string spol;
        #endregion

        #region Konstruktori
        public Zivotinja(string naziv, int godine, string spol)
        {
            this.Naziv = naziv;
        }
        #endregion

        #region Svojstva
        private string Naziv
        {   set
            {
                if(string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Neispravan unos!");
                }
                this.naziv = value;
            } 
        }
        private int Godine
        {
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Neispravan unos!");
                }
                this.godine = value;
            }
        }
        private string Spol
        {
            set
            {
                if(string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Neispravan unos!");
                }
                this.spol = value;
            }
        }
        #endregion

        #region Metode
        public abstract string KakoSeGlasa();
        public override string ToString()
        {
            return string.Format("{0}{1}{2} {3} {4}{1}{5}",
                this.GetType().Name,
                Environment.NewLine,
                this.naziv,
                this.godine,
                this.spol,
                this.KakoSeGlasa());
        }
        #endregion

    }
}
