using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osobni_podaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime_prezime;
            string grad;
            int starost;
            int postanski_broj;

            Console.Write("Unesite ime i prezime: ");
            ime_prezime = Console.ReadLine();

            Console.Write("Unesite grad: ");
            grad = Console.ReadLine();


            Console.Write("Unesite svoje godine: ");
            starost = int.Parse(Console.ReadLine());

            Console.Write("Unesite svoj postanski broj: ");
            postanski_broj = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("================Vasi detalji================");
            Console.WriteLine("============================================\n");

            Console.WriteLine("Ime i prezime: " + ime_prezime);
            Console.WriteLine("Grad: " + grad);
            Console.WriteLine("Starost: " + starost);
            Console.WriteLine("Postanski broj: " + postanski_broj);
            Console.WriteLine("============================================");

            
        }
    }
}
