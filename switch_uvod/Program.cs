using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prijmer provjere dana u tjednu po broju dana: ");
            Console.WriteLine();

            int dan_u_tjednu = 5;
            switch(dan_u_tjednu%7+1) 
            {
                case 1:
                    Console.WriteLine("Ponedjeljak");
                    break;
                case 2:
                    Console.WriteLine("Utorak");
                    break;
                case 3:
                    Console.WriteLine("Srijeda");
                    break;
                case 4:
                    Console.WriteLine("Cetvrtak");
                    break;
                case 5:
                    Console.WriteLine("Petak");
                    break;
                case 6:
                    Console.WriteLine("Subota");
                    break;
                case 7:
                    Console.WriteLine("Nedjelja");
                    break;
                default:
                    Console.WriteLine("Nemam pojma koji je dan.");
                    break;

            }
            Console.WriteLine("=====================================");
            Console.WriteLine("Primjer porvjere dali je prolazna ocjena: ");
            Console.WriteLine();

            int ocjena = 2;
            switch(ocjena)
            {
                case 1:
                    Console.WriteLine("Nije prolazna ocjena");
                    break;
                case 2:
                case 3:
                case 4: 
                case 5:
                    Console.WriteLine("Prolazna ocjena!");
                    break;
                default:
                    Console.WriteLine("Nepoznata ocjena!");
                    break;
            }

            Console.WriteLine("====================================");
            Console.WriteLine("Primjer ispisa teksta ovisno o unesenom tekstu: ");
            Console.WriteLine();

            Console.Write("Unesite dan u tjednu rijecima: ");
            string dan = Console.ReadLine();

            switch(dan.ToLower())
            {
                case "ponedjeljak":
                    Console.WriteLine("Idemo na posao :");
                    break;
                case "utorak":
                    Console.WriteLine("Ni blizu vikenda!");
                    break;
                case "srijeda":
                    Console.WriteLine("Sredina tjedna!");
                    break;
                case "cetvrtak":
                    Console.WriteLine("Mali petak.");
                    break;
                case "petak":
                    Console.WriteLine("Jedva cekam otici s posla!");
                    break;
                case "subota":
                case "nedjelja":
                    Console.WriteLine("Vikend");
                    break;
                default:
                    Console.WriteLine("?????");
                    break;
            }

        }

    }
}
