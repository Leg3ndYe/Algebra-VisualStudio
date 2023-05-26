using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_rekurzija_i_permutacije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rekurzija: generiranje svih mogucih permutacija niza: ");

            Console.Write("Unesite broj elemenata koji ce se pohraniti u polje (najvise 5): ");
            int broj_elemenata = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite {0} elemenata u polje: ", broj_elemenata);
            int[] brojevi = new int[5];
            for(int i = 0; i < broj_elemenata; i++)
            {
                Console.Write("Element {0}: ", i+1);
                brojevi[i] = int.Parse(Console.ReadLine());
            }

            Permutacije test = new Permutacije();
            Console.WriteLine("Permutacije s kombinacijom {0} znamenki su: \n", broj_elemenata);
            test.IspisPermutacije(brojevi, 0, broj_elemenata - 1);
        }
    }
}
