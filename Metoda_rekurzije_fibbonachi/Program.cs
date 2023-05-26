using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoda_rekurzije_fibbonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rekurzija: Fibbonachijevi brojevi: ");
            Console.WriteLine();

            Console.Write("Unesite koji broj Fibbonachijevog niza zelite: ");
            int broj = Convert.ToInt32(Console.ReadLine());

            DateTime kraj, poc;

            Console.WriteLine("Rekurzivno");
            poc = DateTime.Now;
            Console.WriteLine("{0}. Fibbonachijev broj je {1}", broj, Fib(broj));
            kraj = DateTime.Now;
            Console.WriteLine("Trajanje(ms): " + (kraj - poc).TotalMilliseconds);
            Console.WriteLine("Nerekurzivno");
            poc = DateTime.Now;
            Console.WriteLine("{0}. Fibbonachijev broj je {1}", broj, FibNR(broj));
            kraj = DateTime.Now;
            Console.WriteLine("Trajanje(ms): " + (kraj - poc).TotalMilliseconds);

        }

        public static int Fib(int broj)
        {
            if (broj <= 1) return 1;
            return Fib(broj - 1) + Fib(broj - 2);
        }

        public static int FibNR(int broj)
        {
            if(broj <= 1) return 1;
            int trenutni = 1, prosli = 1, pretprosli = 1;

            for(int i = 2; i <= broj; i++)
            {
                trenutni = prosli + pretprosli;
                pretprosli = prosli;
                prosli = trenutni;
            }
            return trenutni;
        }
    }
}
