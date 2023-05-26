using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_while_unos_ocjene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unos ocjene. Ukoliko ocjena nije ispravno unesena, traziti od koristika da ponovi unos!!");
            Console.WriteLine();

            int ocjena = 0;

            do 
            {
                Console.Write("Unesite ocjenu: ");
                ocjena = Convert.ToInt32(Console.ReadLine());

                if (ocjena >= 1 && ocjena <= 5) 
                {
                    break;
                }
                Console.WriteLine("Krivo unesena ocjena! Molim ponovite unos!");
                Console.WriteLine();
            }while (true);
            Console.WriteLine("Ispravno ste unijeli {0}", ocjena);

        }
    }
}
