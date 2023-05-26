using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_rekurzija_faktorijele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rekurzija: Faktorijele danog broja: ");
            Console.WriteLine();

            Console.Write("Unesite broj: ");
            int broj = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}!={1}",broj,Faktorijele(broj));
        }
        public static decimal Faktorijele(int broj)
        {
            if (broj <= 1) return 1;
            return broj*Faktorijele(broj-1); 
        }
    }
}
