using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_poslovanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izracun prihoda i gubitaka: ");
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            float trosak, cijena, ruc;

            Console.Write("Unesite cijenu troska: ");
            trosak = Convert.ToSingle(Console.ReadLine());
            Console.Write("Unesite prodajnu cijenu: ");
            cijena = Convert.ToSingle(Console.ReadLine());
            ruc = cijena - trosak;

            if (ruc > 0)
            {
                Console.WriteLine("Iznos dobiti je {0} eura.", ruc);
            }
            else if (ruc < 0)
            {
                Console.WriteLine("Izgubili smo {0} eura.", (-1) * ruc);
            }
            else Console.WriteLine("Na nuli smo, nema zarade ni gubitka!");
        }
    }
}
