using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer jednostavne metode: ");
            Console.WriteLine();

            MojaMetoda();

            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("Primjer jednostavne metode s parametrom: ");

            MojaMetoda();
            MojaMetodaSParametrom("Lukas");
            MojaMetodaSParametrom();

            Console.Write("Unesite ime: ");
            MojaMetodaSParametrom(Console.ReadLine());
        }

        static void MojaMetoda()
        {
            Console.WriteLine("Dobar dan i dobrodosli.");
        }

        static void MojaMetodaSParametrom(string ime = "nema imena")
        {
            Console.WriteLine("Pozdrav " + ime);
        }




    }
}
