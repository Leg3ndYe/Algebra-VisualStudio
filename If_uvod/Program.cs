using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prijmer if-a: ");
            string vrijeme = "Suncano";
            if (vrijeme == "Suncano")
            {
                Console.WriteLine("Danas je lijep i suncan dan!");
            }

            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("Prijmer ugnjezdivanje if-a: ");
            Console.WriteLine();

            string vremenska_prognoza = "Oblacno";
            bool pada_kisa = false;
            if(vremenska_prognoza == "Oblacno")
            {
                string tekst = "Vrijeme je oblacno";
                if (pada_kisa)
                {
                    tekst += ", ponesite kisobran.";
                }
                else
                {
                    tekst += ", no ne pada nista.";
                }
                Console.WriteLine(tekst);
            }
            else
            {
                Console.WriteLine("Suncano je.");
            }

            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("Prijmer prosirenog if-else: ");
            Console.WriteLine();

            int x = 10;
            int y = 4;

            if(x > y) 
            {
                Console.WriteLine(x + "je veci od " + y);
            }
            else if (x < y)
            {
                Console.WriteLine(x + "je manji od " + y);
            }
            else
            {
                Console.WriteLine(x + "je jednak " + y);
            }

            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("Prijmer prosirenog if-else: ");
            Console.WriteLine();

            string veci_od = (x > 5) ? x + "je veci od 5" : x + "je manji od 5";
            if (x > 5)
            {
                veci_od = x + "je veci od 5";
            }
            else
            {
                veci_od = x + "je manje od 5";
            }

            Console.WriteLine(veci_od);
        }
    }
}
