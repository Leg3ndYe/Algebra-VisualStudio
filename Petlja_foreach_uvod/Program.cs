using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_foreach_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jednostavna foreach petlja: ");
            Console.WriteLine();

            string[] automobili = { "Honda", "Mazda", "Ford", "BMW", "KIA" };
            foreach(string auto in automobili)
            {
                Console.WriteLine(auto);
            }

            Console.WriteLine("===========================================");
            Console.WriteLine("Primjer foreach s brojanjem muskaraca i zena");

            char[] spolovi = { 'm', 'z', 'z', 'm', 'm', 'z', 'm', 'm', 'z', 'm', };
            int m = 0, z = 0;

            foreach(char spol in spolovi)
            {
                if (spol == 'm') m++;
                else if (spol == 'z') z++;
            }
            Console.WriteLine("Broj muskaraca je " + m);
            Console.WriteLine("Broj zena je " + z);

            Console.WriteLine("===========================================");
            Console.WriteLine("Primjer foreach s kolkcijama: ");

            List<int> brojevi = new List<int>() { 13, 29, 28, 11, 24, 4, 666, 0, 7};
            int suma = 0;

            foreach(int broj in brojevi)
            {
                suma += broj;
            }
            Console.WriteLine("Zbroj brojeva je " + suma);

            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.WriteLine("Primjer foreach s break i continue: ");
            Console.WriteLine();

            var prezimena = new List<string>() { "Tesla", "Marulic", "Kozarac", "Tadijanovic", "Penkalo"};
            foreach(var prezime in prezimena)
            {
                if (prezime == "Kozarac")
                {
                    Console.WriteLine("Nasao sam koga sam trazio");
                    break;
                }
                Console.WriteLine(prezime);
            }

            Console.WriteLine();
            foreach (var prezime in prezimena)
            {
                if (prezime == "Tadijanovic")
                {
                    Console.WriteLine("Ignoriramo");
                    continue;
                }
                Console.WriteLine(prezime);
            }
        }
    }
}
