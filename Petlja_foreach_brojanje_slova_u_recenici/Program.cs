using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_foreach_brojanje_slova_u_recenici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unos recenice i brojanje koliko recenica ima slova \"n\" ");
            Console.WriteLine();

            Console.Write("Unesite recenicu: ");
            string recenica = Console.ReadLine();

            int brojac = 0;
            foreach(char znak in recenica.ToLower().ToCharArray())
            {
                if(znak == 'n')  brojac++; 
            }
            Console.WriteLine("U recenice je pronadjeno {0} znakova \"n\"", brojac);
        }
    }
}
