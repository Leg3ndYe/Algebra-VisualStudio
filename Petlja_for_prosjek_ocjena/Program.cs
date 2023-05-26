using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_prosjek_ocjena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unos broja predmeta, nakon toga ocejne i ispis prosjeka!");
            Console.WriteLine();

            Console.Write("Unesite broj predmeta: ");
            int broj_predmeta = Convert.ToInt32(Console.ReadLine());
            int suma = 0, ocjena = 0;
            bool nedovoljan = false;

            for (int i = 0; i < broj_predmeta; i++) 
            {
                Console.Write("Unesite ocjenu za {0}. predmet: ", i + 1);
                ocjena = Convert.ToInt32(Console.ReadLine());
                if(ocjena < 1 || ocjena > 5)
                {
                    Console.WriteLine("Neispravno unesena ocjena!! Ponovite unos!!");
                    i--;
                    continue;
                }
                if(ocjena == 1) 
                {
                    nedovoljan = true;
                    break;
                }
                suma += ocjena;
            }
            Console.WriteLine();
            
            if (nedovoljan)
            {
                Console.WriteLine("Uspjeh je nedovoljan! Popravak ili pad godine!!");
            }
            else
            {
                Console.WriteLine($"Prosjek ocjena za {broj_predmeta} predmeta je {Math.Round((decimal)suma / broj_predmeta, 2)} :)");
            }

        }
    }
}
