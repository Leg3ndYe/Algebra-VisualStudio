using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polja_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prijmer deklaracije i inicijalizacije: ");
            Console.WriteLine();

            int[] brojevi = new int[3];
            brojevi[0] = 10;
            brojevi[2] = 144;
            brojevi[1] = 15;

            foreach(int i in brojevi)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine("Primjer deklaracije i inicijalizacije u jednom redu: ");
            Console.WriteLine();

            string[] gradovi = new string[4] { "Vinkovci", "Osijek", "Zadar", "" };
            Console.WriteLine("Ispis 1. elementa : {0}", gradovi[0]);
            Console.WriteLine("Ispis 2. elementa : {0}", gradovi[1]);
            Console.WriteLine("Ispis 3. elementa : {0}", gradovi[2]);
            Console.WriteLine("Ispis 4. elementa : {0}", gradovi[3]);
            //Console.WriteLine("Ispis 5. elementa : {0}", gradovi[4]);

            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine("Primjer azuriranja elemenata s nepoznatim brojem elemenata: ");
            Console.WriteLine();

            string[] automobili = { "Honda", "Toyota", "BMW", "Mazda"};
            automobili[2] = "Mitsubish";

            Console.WriteLine("Ispis 1. elementa : {0}", automobili[0]);
            Console.WriteLine("Ispis 2. elementa : {0}", automobili[1]);
            Console.WriteLine("Ispis 3. elementa : {0}", automobili[2]);
            Console.WriteLine("Ispis 4. elementa : {0}", automobili[3]);

            string[] filmovi;
            filmovi = new string[] { "Matrix", "Constantine", "John Wick", "American Pie"};
            Console.WriteLine("Ispis 1. elementa : {0}", filmovi[0]);
            Console.WriteLine("Ispis 2. elementa : {0}", filmovi[1]);
            Console.WriteLine("Ispis 3. elementa : {0}", filmovi[2]);
            Console.WriteLine("Ispis 4. elementa : {0}", filmovi[3]);

        }
    }
}
