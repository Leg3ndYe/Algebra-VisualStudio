using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Varijable_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string moje_ime = "Lukas";
            int cijeli_broj = 5;
            double decimalni_broj = 5.5;
            bool tocno = true;
            char znak = 'a';

            Console.WriteLine($"Moje ime je: {moje_ime}");
            Console.WriteLine("Cijeli broj je: " + cijeli_broj);
            Console.WriteLine("Decimalni broj je {0}", decimalni_broj);
            Console.WriteLine("Tocno je: " + tocno);
            Console.WriteLine("Znak je: " + znak);
        }
    }
}
