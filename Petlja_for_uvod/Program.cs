using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ispis brojeva od 1 do 10: ");
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }

            Console.WriteLine();
            Console.WriteLine("Ispis brojeva od 10 do 1");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            for (int i = 5; i < 100; i = i+5)
            {
                Console.WriteLine(i);
            }
        }
    }
}
