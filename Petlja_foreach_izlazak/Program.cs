using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_foreach_izlazak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("U kolekciji brojeva, ne uzimati u obzir brojeve nakon 15!");

            int[] neparni_brojevi = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23 };

            foreach(var broj in neparni_brojevi)
            {
                Console.WriteLine(broj);
                if (broj >= 5) break;
            }
            
        }
    }
}
