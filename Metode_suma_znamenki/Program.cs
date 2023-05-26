using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_suma_znamenki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metoda za racunanje zbroja znamenki broja.");
            Console.WriteLine();

            Console.Write("Unesite broj: ");
            int broj = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zbroj znamenki broj {0} je {1} ", broj, ZbrojZnamenki(broj));

        }

        private static int ZbrojZnamenki(int broj)
        {
            int zbroj = 0;

            //1. nacin previse konverzija ;)
            
            string broj_s = broj.ToString();
            for(int i = 0; i < broj_s.Length; i++)
            {
                zbroj += Convert.ToInt32(broj_s[i]);
            }

            //2. nacin bez ikakve konverzije ;)
            zbroj = 0;
            do
            {
                zbroj += (broj % 10);
                broj /= 10;
            } while (broj != 0);
            return zbroj;
        }
        
    }
}
