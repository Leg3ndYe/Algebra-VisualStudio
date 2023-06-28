using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Djeljenje(21, 0);
            Console.WriteLine();
            Console.WriteLine();
            Djeljenje(35, 5);
        }

        static void Djeljenje(int a, int b)
        {
            float rez = float.MaxValue;
            try
            {
                rez = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Uhvacena iznimka: " + e.Message);
            }
            finally
            { 
                Console.WriteLine("Rezultat je "+ rez.ToString()); 
            }
        }
    }
}
