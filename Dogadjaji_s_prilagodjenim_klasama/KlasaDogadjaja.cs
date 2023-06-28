using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_s_prilagodjenim_klasama
{
    class KlasaDogadjaja
    {
        public event EventHandler<KlasaStatusa> ProcesZavrsen;

        public void ProcesPocinje()
        {
            var stat = new KlasaStatusa();

            try
            {
                Console.WriteLine("Proces zapoceo!!");
                //dio koda procesa

                stat.Status_procesa = true;
            }
            catch 
            {
                stat.Status_procesa = false; 
            }
            stat.Vrijeme_zavrsetka = DateTime.Now;
            KadProcesZavrsi(stat);
        }

        protected virtual void KadProcesZavrsi(KlasaStatusa status)
        {
            ProcesZavrsen?.Invoke(this, status);
        }
    }
}
