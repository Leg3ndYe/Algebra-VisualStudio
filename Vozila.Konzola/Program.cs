using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vozila.Model;

namespace Vozila.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vozilo> vozila = new List<Vozilo>();
            Automobili auti = new Automobili();

            do
            {
                Console.WriteLine("Zelite li unjeti automobil ili brod? (a=auto, b=brod)");
                string unos = Console.ReadLine();
                switch(unos.ToLower())
                {
                    case "a":
                        Automobil a = UcitajAutomobil();
                        auti.Add(a);
                        vozila.Add(a);
                        break;
                    case "b":
                        Brod b = ucitajBrod();
                        break;
                    default:
                        Console.WriteLine("Ne znam sta je odabir. Probajte ponovno!");
                        break;
                }
                izbor:
                Console.WriteLine("Zelite li unijeti jos jedno vozilo? (d=da, n=ne)");
                unos = Console.ReadLine();
                if (unos.ToLower() == "n") break;
                if (unos.ToLower() == "d") continue;
                goto izbor;

            } while (true);

        }

    

        static Automobil UcitajAutomobil()
        {
            Console.Write("Unesite naziv automobila: ");
            string naziv = Console.ReadLine();

            Console.Write("Unesite boju automobila: ");
            string boja = Console.ReadLine();

            Console.Write("Unesite snagu automobila: ");
            int snaga = int.Parse(Console.ReadLine());

            Console.Write("Unesite zapremninu motora u kubicnim centimetrima: ");
            int ccm = int.Parse(Console.ReadLine());

            Console.Write("Unesite broj sasije (17 znakova): ");
            string sasija = Console.ReadLine();

            Automobil auto = new Automobil(naziv, boja, snaga, sasija, ccm);

            return auto;
        }
        static Brod UcitajBrod()
        {
            Console.Write("Unesite naziv broda: ");
            string naziv = Console.ReadLine();

            Console.Write("Unesite boju broda: ");
            string boja = Console.Readline();

            
        }
    }
}
