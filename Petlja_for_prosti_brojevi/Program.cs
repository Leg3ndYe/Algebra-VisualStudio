using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_prosti_brojevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ispis prostih brojeva u odabranom rasponu: ");
            Console.WriteLine();

            int pocetak = 0, kraj = 0;
            Console.Write("Unesite pocetni broj: ");
            pocetak = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite zavrsni broj: ");
            kraj = Convert.ToInt32(Console.ReadLine());

            for(int i = pocetak; i <= kraj; i++) 
            {
                bool prost = true;
                for (int j = 2; j < i; j++)
                {
                    if(i%j == 0) 
                    {
                        prost = false;
                        break;
                    }
                }
                if (prost) { Console.WriteLine(i); }
            }

        }
    }
}
