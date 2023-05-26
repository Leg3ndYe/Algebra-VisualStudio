using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Metode_min_max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metode za zamjenu mjesta najveceg i najmanjeg broja u kolekciji: ");
            Console.WriteLine();

            int[] brojevi = new int[10];

            for (int i = 0; i< 10; i++)
            {
                Console.Write($"Unesite {i + 1}. broj: ");
                brojevi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Brojevi prije zamjene: ");
            Ispis(brojevi);
            ZamjeniMaxMinBrojeve(brojevi);
            Console.WriteLine("Brojevi nakon zamjene: ");
            Ispis(brojevi);
        }

        public static void Ispis(int[] brojevi)
        {
            for(int i = 0; i< brojevi.Length; i++)
            {
                Console.Write(brojevi[i] + "\t");
            }
            Console.WriteLine();
        }
        public static void ZamjeniMaxMinBrojeve(int[] brojevi)
        {
            int max = 0, min = 0;
            for(int i = 1; i<brojevi.Length; i++)
            {
                if (brojevi[i] > brojevi[max]) max = i;
                if (brojevi[i] < brojevi[min]) min = i;
            }
            int pom = brojevi[min];
            brojevi[min] = brojevi[max];
            brojevi[max] = pom;
        }
    }
}
