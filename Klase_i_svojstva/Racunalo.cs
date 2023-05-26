using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_svojstva
{
    class Racunalo
    {
        #region Private Members

        private string markaProcesora;
        private int kapacitetDiska;
        private int radnaMemorija;

        #endregion
        #region Properties

        public string MarkaProcesora
        {
            get { return markaProcesora; }
            set { markaProcesora = value; }
        }

        public int KapacitetDiska
        {
            get { return kapacitetDiska; }
            set { kapacitetDiska = value; }
        }
        public int RadnaMemorija
        {
            get { return radnaMemorija; }
        }
        #endregion
        #region Constructors

        public Racunalo(int RAM) 
        {
            radnaMemorija = RAM;
        }

        public Racunalo(string CPU, int RAM, int Drive)
        {
            markaProcesora = CPU;
            kapacitetDiska = Drive;
            radnaMemorija = RAM;
        }

        #endregion
        #region Methods
        public void DodajMemoriju(int dodatak)
        {
            radnaMemorija += dodatak;
        }
        #endregion
    }
}
