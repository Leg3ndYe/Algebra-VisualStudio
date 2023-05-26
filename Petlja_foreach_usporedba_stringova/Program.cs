using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_foreach_usporedba_stringova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ispisati polje stringova, a zatim ispis obrnutim redoslijedom");
            Console.WriteLine();

            string[] zivotinje = { "Zmija", "Pas", "Ptica", "Konj" };
            Console.WriteLine("Originalni redoslijedom: ");
            foreach(string zivotinja in zivotinje) 
            {
                Console.Write(zivotinja + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Ipis obrnutim redosiljedom: ");
            foreach(string zivotinja in zivotinje.Reverse())
            {
                Console.Write(zivotinja + " ");
            }

            Console.WriteLine();
        }
    }
}
