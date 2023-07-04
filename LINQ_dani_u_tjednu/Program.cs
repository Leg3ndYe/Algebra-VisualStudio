using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_dani_u_tjednu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] DaniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Cetvrtak", "Petak", "Subota", "Nedjelja" };

            var prvaTriSlova = from dan in DaniUTjednu
                               select dan.Substring(0, 3);

            foreach (var dan in prvaTriSlova)
            {
                Console.WriteLine(dan);
            }
            Console.WriteLine();
        }
    }
}
