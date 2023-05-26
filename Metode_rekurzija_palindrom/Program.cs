using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_rekurzija_palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rekurzija: Provjera je li rijec palindrom ili ne: ");
            Console.WriteLine();

            Console.Write("Unesite rijec: ");
            string rijec = Console.ReadLine();

            if (JePalindrom(rijec)) Console.WriteLine("Rijec \"{0\" je palindrom",rijec);
            else Console.WriteLine("Nije Palindrom!");
        }

        public static bool JePalindrom(string rijec)
        {
            if (rijec.Length <= 1) return true;
            else
            {
                if (rijec[0] != rijec[rijec.Length - 1]) return true;
                else return JePalindrom(rijec.Substring(1, rijec.Length-2));
            }
            
            
            
            
           
        }
    }
}
