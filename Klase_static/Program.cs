using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double broj = StaticnaKlasa.Zbroj(4, 6);

            Console.Write("Unesite broj: ");
            int b = int.Parse(Console.ReadLine());

            if(StaticnaMetoda.Prost(b))
            {
                Console.WriteLine("Broj je prost.");
            }
            else { Console.WriteLine("Broj nije prost.");  }

            StaticnaMetoda sm = new StaticnaMetoda();
            if(sm.Savrsen(b))
            {
                Console.WriteLine("Broj je savrsen.");
            }
            else { Console.WriteLine("Broj nije savrsen."); }

        }
    }
}
