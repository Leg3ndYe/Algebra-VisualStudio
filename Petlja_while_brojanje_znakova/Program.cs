using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_while_brojanje_znakova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brojanje slova znamenki i posebnih znakova u recenici.");
            Console.WriteLine();

           
            string recenica = "";
            int slova = 0, znamenke = 0, spec_znakovi = 0, i=0;

            Console.Write("Unesite recenicu: ");
            recenica = Console.ReadLine();  

            while (recenica.Length > i) 
            {
                if ((recenica[i] >= 'a' && recenica[i] <= 'z') || (recenica[i] >= 'A' && recenica[i] <= 'Z')) slova++;
                else if (recenica[i] >= '0' && recenica[i] <= '9') znamenke++;
                else spec_znakovi++;
                i++;

            }

            Console.WriteLine($"Recenica ima {slova} slova, {znamenke} znamenki i {spec_znakovi} specijalnih znakova.");


        }
    }
}
