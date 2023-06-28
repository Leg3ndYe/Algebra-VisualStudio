using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati_multicast
{
    public delegate void TestDelegat(string poruka);
    internal class Program
    {  
        static void Main(string[] args)
        {
            TestDelegat del1 = KlasaA.MetodaA;
            TestDelegat del2 = KlasaB.MetodaB;

            TestDelegat del = del1 + del2;
            del("Prvi!");
            Console.WriteLine("==========================");

            TestDelegat del3 = (string por) => Console.WriteLine("Lambda izraz poziv: " + por);
            del += del3;
            del("Drugi!");
            Console.WriteLine("==========================");

            del = del - del2;
            del("Treci!");
            Console.WriteLine("==========================");

            del -= del1;
            del("Cetvrti!");
            Console.WriteLine("==========================");

            del += del3;
            del("Peti!");
            Console.WriteLine("==========================");

        }
    }
    public class KlasaA
    {
        public static void MetodaA(string poruka)
        {
            Console.WriteLine("Pozvali smo klasaA.MetodaA() s parametrima: " + poruka);
        }
    }
    public class KlasaB
    {
        public static void MetodaB(string poruka)
        {
            Console.WriteLine("Pozvali smo klasaB.MetodaB() s parametrima: " + poruka);
        }
    }
}
