using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoda_brojanje_razmaka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metoda za brojanje razmaka u recenici: ");

            Console.Write("Unesite recenicu: ");
            string recenica = Console.ReadLine();

            Console.WriteLine("Recenica ima {0} razmaka", GetBrojRazmaka(recenica));
        }
        static int GetBrojRazmaka(string recenica)
        {
            int razmaci = 0;
            for (int i = 0; i < recenica.Length; i++)
            {
               if (recenica[i] == ' ') razmaci++;
            }
            return razmaci;
        }
    }
}
