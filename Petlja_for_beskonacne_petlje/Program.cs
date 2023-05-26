using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_beskonacne_petlje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer beskonacne petlje (namjerna greska)");
            Console.WriteLine();

            for (int x = 10; x > 0; x++)
            {
                Console.Write(x + " ");

            }

            //for (int i = 10; i > 0; i = i * 2)
            //{
            //    if (i > 10000) break;
            //    Console.WriteLine(i + " ");
            //}
        }
    }
}
