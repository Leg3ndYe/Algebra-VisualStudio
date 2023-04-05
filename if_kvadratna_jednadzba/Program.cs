using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_kvadratna_jednadzba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            Console.WriteLine("Izracun nultocki parabole (kvadratne jednadzbe)");
            Console.WriteLine("===============================================");
            Console.WriteLine();

            Console.Write("Unesite vrijednost za a: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Unesite vrijednost za b: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Unesite vrijednost za c: ");
            c = Convert.ToSingle(Console.ReadLine());

            float d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("jednadzba nema realnih rjesenja.");
            }
            else
            {
                float x1, x2;
                d = (float)Math.Sqrt(d);
                x1 = ((-1) * b + d) / (2 * a);
                x2 = ((-1) * b - d) / (2 * a);

                Console.WriteLine("X1 = {0}\nX2 = {1}", x1, x2);
            }
        }
    }
}
