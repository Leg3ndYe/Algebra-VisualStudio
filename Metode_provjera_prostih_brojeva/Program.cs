using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_provjera_prostih_brojeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provjera prostih brojeva: ");
            Console.WriteLine();

            Console.WriteLine("Unesite broj: ");
            int n = int.Parse(Console.ReadLine());
            if (Prost(n)) Console.WriteLine("Broj je prost.");
            else Console.WriteLine("Broj nije porst!");

            Console.WriteLine("==============================================");
            Console.WriteLine("Ispis prostih brojeva u rasponu od 30 do 200");

            for (int i = 30; i<200;i++)
            {
                if (Prost(i)) Console.WriteLine(i);
            }
        }
        public static bool Prost(int n)
        {
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
