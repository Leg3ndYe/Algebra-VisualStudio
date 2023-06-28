using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_i_proslijedjivanje_podataka
{
    class KlasaDogadjaja
    {
        public event EventHandler<bool> ProcesZavrsen;

        public void ProcesPocinje()
        {
            try
            {
                Console.WriteLine("Proces je poceo!");
                //neki drugi kod metode...
                KadaProcesZavrsi(true);
            }
            catch 
            {
                KadaProcesZavrsi(false);
            }
        }
        protected virtual void KadaProcesZavrsi(bool status_procesa)
        {
            ProcesZavrsen?.Invoke(this, status_procesa);
        }
    }
}
