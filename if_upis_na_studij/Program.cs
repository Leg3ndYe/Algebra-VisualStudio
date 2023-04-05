using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_upis_na_studij
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kriterij prihvatljivosti: ");
            Console.WriteLine("Bodovi iz matemtike >= 65 ");
            Console.WriteLine("i bodovi iz fizike >= 55");
            Console.WriteLine("i bodovi iz kemije >= 50");
            Console.WriteLine("i ukupno za sva tri predmeta >= 180");
            Console.WriteLine("ili ukupno iz matematike i fizike >= 140");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            int mat, fiz, kem;
            Console.Write("Unesite bodove iz matematike: ");
            mat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite bodove iz fizike: ");
            fiz = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite bodove iz kemije: ");
            kem = Convert.ToInt32(Console.ReadLine());

            if (mat >= 65)
            {
                if (fiz >= 55)
                {
                    if (kem >= 50)
                    {
                        if ((mat + fiz + kem) >= 180 || (mat + fiz) >= 140)
                        {
                            Console.WriteLine("Uvjeti za upis su ispunjeni!");
                        }
                        else Console.WriteLine("Uvjeti za upis nisu ispunjenji!");
                    }
                    else Console.WriteLine("Nedovoljno bododva iz kemije!");
                }
                else Console.WriteLine("Nedovoljno bodova iz fizike!");
            }
            else Console.WriteLine("Nedovoljno bodova iz matematike!");

        }
    }
}
