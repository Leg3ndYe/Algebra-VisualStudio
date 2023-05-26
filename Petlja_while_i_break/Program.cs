using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_while_i_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer while petlje za unos imena. Petlju prekinuti na unos rijeci kraj!");
            Console.WriteLine();

            while(true) 
            {
                Console.Write("Unesite ime: ");
                string ime = Console.ReadLine();

                if (ime.ToLower().Contains("kraj"))
                {
                    break;
                }
                Console.WriteLine("Dobar dan {0}",ime);
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("============================================");
            Console.WriteLine("Prijasnji primjer bez break!");

            string novo_ime = "";
            while(novo_ime.ToLower() != "kraj")
            {
                Console.WriteLine("Unesite ime: ");
                novo_ime = Console.ReadLine();

                if(novo_ime.ToLower() != "kraj")
                {
                    Console.WriteLine("Upisali ste: " + novo_ime);
                    Console.WriteLine();
                }
            }
        }
    }
}
