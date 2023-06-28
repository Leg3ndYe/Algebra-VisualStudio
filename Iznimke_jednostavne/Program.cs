using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_jednostavne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Unesite broj: ");
                    
                    var broj = int.Parse(Console.ReadLine());
                    
                    if (broj == 0) break;
                    Console.WriteLine("Kvadrat broja je {0}", broj * broj);
                }
                catch 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("Nije unesen cijeli broj!");
                    Console.WriteLine();
                }
                finally
                { 
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine("Pokusajte unjeti jos jedan broj.");
                    Console.WriteLine("================================");
                    Console.WriteLine();
                }

            }
        }
    }
}
