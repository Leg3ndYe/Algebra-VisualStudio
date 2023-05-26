using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_neparni_brojevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ispis neparnih brojeva vecih od 0, a manjih od 50");
            Console.WriteLine();

            for(int i = 1; i<50; i++)
            {
                if (i % 2 != 0) Console.Write(i + ", ");
            }

            Console.WriteLine();
            for (int i = 0; i < 50; i = i+2)
            {
                Console.Write(i + ", ");
            }
        }
    }
}
