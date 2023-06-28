using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_ugnjezdjivanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi 0: ");

            try
            {
                int broj = int.Parse(Console.ReadLine());

                try
                {
                    Console.WriteLine(666 / broj);
                }
                catch
                {
                    Console.WriteLine("Iznimka inseption.");
                }
            }
            catch
            {
                Console.WriteLine("Najobicnija iznimka.");
            }

        }
    }
}
