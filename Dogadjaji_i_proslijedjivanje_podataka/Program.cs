using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_i_proslijedjivanje_podataka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaDogadjaja k = new KlasaDogadjaja();
            k.ProcesZavrsen += K_ProcesZavrsen;

            k.ProcesPocinje();
        }

        private static void K_ProcesZavrsen(object sender, bool e)
        {
            if(e)
            {
                Console.WriteLine("Proces uspjesno zavrsio zadatak!!");
            }
            else
            {
                Console.WriteLine("Doslo je do greske i nije uspjesno gotovo!!");
            }
        }
    }
}
