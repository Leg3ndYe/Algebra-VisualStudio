using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_filtriranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Unesite broj koji zelite podjeliti s 69: ");

                try
                {
                    int broj = int.Parse(Console.ReadLine());

                    int rez = 69 / broj;

                    Console.WriteLine($"69 / {broj} = {rez}");
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine("Nije moguce djeljenje s 0!");
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("Neispravna operacija!");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Nije valjani format!");
                }
                catch(Exception e) 
                {
                    Console.WriteLine("Doslo je do nepoznate greske!");
                }
            }
        }
    }
}
