using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_foreach_znakovi_u_svaki_red
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unosim recenicu, te u svaki red pisemo po jedan znak, s time da zanemarujemo razmak.");
            Console.WriteLine();

            Console.Write("Unesite recenicu: ");
            string recenica = Console.ReadLine();

            foreach(char znak in recenica.ToCharArray()) 
            {
                if(znak != ' ') Console.WriteLine(znak);
            }
        }
    }
}
