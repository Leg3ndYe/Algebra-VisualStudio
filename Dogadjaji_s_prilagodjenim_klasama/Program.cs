using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_s_prilagodjenim_klasama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaDogadjaja dog = new KlasaDogadjaja();
            dog.ProcesZavrsen += ProcesJeZavrsio;

            dog.ProcesPocinje();
        }

        private static void ProcesJeZavrsio(object sender, KlasaStatusa e)
        {
            Console.WriteLine("Vrijeme zavrsetka: "+e.Vrijeme_zavrsetka.ToShortDateString());
            if(e.Status_procesa)
            {
                Console.WriteLine("Uspjeh procesa!");
            }
            else
            {
                Console.WriteLine("Epic fail!!");
            }
        }
    }
}
