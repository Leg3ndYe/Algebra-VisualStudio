using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Dogadjaji_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaDogadjaja nas_dogadjaj = new KlasaDogadjaja();
            nas_dogadjaj.ProcesZavrsen += ProcesJeZavrsio;

            nas_dogadjaj.ProcesPoceo();
        }

        public static void ProcesJeZavrsio()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Jos malo!");
            Thread.Sleep(1000);
            Console.WriteLine("Samo malo!");
            Thread.Sleep(1000);
            Console.WriteLine("Skoro gotov!");
            Thread.Sleep(1000);
            Console.WriteLine("Gotov sam!");
        }
    }
}
