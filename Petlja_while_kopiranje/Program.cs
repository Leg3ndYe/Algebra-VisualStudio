using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Petlja_while_kopiranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kopiranje jednog stringa u drugi znak po znak: ");
            Console.WriteLine();

            Console.Write("Unesite recenicu: ");
            string recenica = Console.ReadLine();

            string[] recenica2 = new string[recenica.Length];
            
            int i = 0;
            while(i < recenica.Length) 
            {
                recenica2[i] = recenica[i].ToString();
                i++;    
            }

            Console.WriteLine("Prva recenica: " + recenica);
            Console.WriteLine("Druga recenica: " + string.Join("",recenica2));

        }
    }
}
