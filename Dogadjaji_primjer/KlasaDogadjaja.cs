using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_primjer
{
    public delegate void Notifikacija();
    class KlasaDogadjaja
    {
        public event Notifikacija ProcesZavrsen;

        public void ProcesPoceo()
        {
            Console.WriteLine("Nesta smo zapoceli i radimo....");
            KadaProcesZavrsi();
        }
        protected virtual void KadaProcesZavrsi()
        {
            ProcesZavrsen?.Invoke();
        }
    }
}
