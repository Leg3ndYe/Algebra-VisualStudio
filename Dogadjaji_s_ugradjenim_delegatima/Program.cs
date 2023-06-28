using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_s_ugradjenim_delegatima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaDogadjaja nas_d = new KlasaDogadjaja();
            nas_d.ProcesZavrsen += Nas_d_ProcesZavrsen;

            nas_d.ProcesPoceo();
        }

        private static void Nas_d_ProcesZavrsen(object sender, EventArgs e)
        {
            Console.WriteLine("Proces se zavrsava!");
            Console.WriteLine("Proces gotov!");
        }
    }

    class KlasaDogadjaja
    {
        public event EventHandler ProcesZavrsen;

        public void ProcesPoceo()
        {
            Console.WriteLine("Proces poceo!");
            Console.WriteLine("Proces se obradjuje!");
            KadProcesZavrsi(EventArgs.Empty);
            //var ar = new EventArgs();
            //KadProcesZavrsi(ar);
        }

        protected virtual void KadProcesZavrsi(EventArgs e)
        {
            ProcesZavrsen?.Invoke(this, e);
        }
    }
}
