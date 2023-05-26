using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_i_kolekcije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metode s kolekcijama za ispis rijeci obrnuto: ");
            Console.WriteLine();

            List<string> rijeci = new List<string>();
            for(int i = 0; i<4; i++)
            {
                Console.Write("Unesite rijec: ");
                rijeci.Add(Console.ReadLine());
            }
            MojeRijeciNaopako(rijeci);
            Console.WriteLine();
            Console.WriteLine("Metode s kolekcijama za ispis brojeva obrnuto: ");
            Console.WriteLine();

            List<int> brojevi = new List<int>();
            for (int i = 0; i<4; i++)
            {
                Console.Write("Unesite cijeli broj: ");
                brojevi.Add(int.Parse(Console.ReadLine()));
            }
            MojiBrojeviNaopako(brojevi);
        }
        
        public static void MojeRijeciNaopako(List<string> popis_rijeci)
        {
            foreach (string rijec in popis_rijeci)
            {
                for(int i = rijec.Length-1; i>= 0; i--)
                {
                    Console.Write(Convert.ToChar(rijec[i]));
                }
                Console.WriteLine();
            }
        }
        public static void MojiBrojeviNaopako(List<int> popis_brojeva)
        {
            foreach(int broj in popis_brojeva)
            {
                int pom = broj;
                do
                {
                    Console.Write(broj%10);
                    pom = broj / 10;
                } while (pom != 0);

                Console.WriteLine();
                
            }
        }
    }
}
