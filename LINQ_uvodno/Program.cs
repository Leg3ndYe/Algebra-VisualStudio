using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_uvodno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine("Primjer jednostavnog LINQ upita gdje pretrazujemo prezime");
            Console.WriteLine("=========================================================");

            string[] prezimena = { "Matic", "Ivic", "Katalinic", "Programercic" };

            var nasLinqUpit = from prezime in prezimena
                              where prezime.Contains("Katalinic")
                              select prezime;

            foreach(var prezime in nasLinqUpit )
            { 
                Console.Write(prezime + " "); 
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=========================================================");
            Console.WriteLine("Primjer jednostavnog LINQ upita gdje pretrazujemo imena koja imaju slovo 'l' u imenu");
            Console.WriteLine("=========================================================");

            string[] imena = { "Ana", "Iva", "Katarina", "Alen", "Matija", "Branko", "Antonija", "Luka", "Danijel", "Nikola", "Veigar" };

            var pronadjiLIme = from ime in imena
                               where ime.ToLower().Contains('l')
                               select ime;

            foreach(var ime in pronadjiLIme)
            {
                Console.Write(ime + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=========================================================");
            Console.WriteLine("Primjer jednostavnog LINQ upita, vracamo samo pozitivne brojeve");
            Console.WriteLine("=========================================================");

            int[] brojevi = { 13, 69, -5, 0, 1, 666, -13, -2, 156, 12, -165, 432, 9, -4 };

            var pozitivni_brojevi = from broj in brojevi
                                    where broj >= 0
                                    select broj;

            foreach (var broj in pozitivni_brojevi)
            {
                Console.Write(broj + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=========================================================");
            Console.WriteLine("Primjer jednostavnog LINQ upita, vracamo samo dvoznamenkaste brojeve");
            Console.WriteLine("=========================================================");

            var trazeniBrojevi = from broj in brojevi
                                 where Math.Abs(broj)>9 && Math.Abs(broj)<100
                                 select broj;

            foreach (var broj in trazeniBrojevi)
            {
                Console.Write(broj + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
