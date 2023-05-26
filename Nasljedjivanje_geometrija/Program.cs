using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_geometrija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var krug = new Kruznica();
            krug.Radius = 13.69;

            Console.WriteLine("Karakteristike kruga: ");
            Console.WriteLine("Radius: " + krug.Radius);
            Console.WriteLine("Promjer: " + krug.Promjer);
            Console.WriteLine("Povrsina: " + krug.Povrsina);
            Console.WriteLine("Opseg: " + krug.Opseg);
            Console.WriteLine();

            var lopta = new Kugla();
            lopta.Radius = 13.69;

            Console.WriteLine("Karakteristike kugle: ");
            Console.WriteLine("Radius: " + lopta.Radius);
            Console.WriteLine("Promjer: " + lopta.Promjer);
            Console.WriteLine("Povrsina: " + lopta.Povrsina);
            Console.WriteLine("Volumen: " + Math.Round(lopta.Opseg,2));
            Console.WriteLine();
        }
    }
}
