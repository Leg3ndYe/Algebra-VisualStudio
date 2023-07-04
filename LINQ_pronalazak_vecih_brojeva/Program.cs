using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_pronalazak_vecih_brojeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int listaBrojeva, x, y;

            List<int> tempLista = new List<int>();

            Console.Write("Koliko brojeva zelite unijeti: ");
            x=int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(i = 0; i < x; i++)
            {
                Console.Write("{0}. broj: ", i + 1);
                listaBrojeva = int.Parse(Console.ReadLine());
                tempLista.Add(listaBrojeva);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Unesite broj donju granicu brojeva: ");
            y = int.Parse(Console.ReadLine());

            List<int> FiltrirajListu = tempLista.FindAll(j => j > y ? true : false);

            FiltrirajListu = (from j in tempLista
                              where j > y
                              select j).ToList();

            Console.WriteLine("Brojevi veci od " + y );
            foreach(var broj in FiltrirajListu)
            {
                Console.WriteLine(broj);
            }


        }
    }
}
