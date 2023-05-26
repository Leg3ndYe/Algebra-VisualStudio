using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_i_string_s_razmacima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Poredati znakove u recenici rastucim redoslijedom. ");
            Console.WriteLine();

            Console.Write("Unesite recenicu: ");
            string recenica = Console.ReadLine();

            char[] znakovi = recenica.ToCharArray();

            for(int i =0; i<znakovi.Length; i++) 
            {
                for(int j=i+1; j<znakovi.Length; j++)
                {
                    if (znakovi[i] > znakovi[j])
                    {
                        char pom = znakovi[i];
                        znakovi[i] = znakovi[j];
                        znakovi[j] = pom;
                    }
                }
            }
            Console.WriteLine("Sortirana slova: ");
            foreach (char c in znakovi) 
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
