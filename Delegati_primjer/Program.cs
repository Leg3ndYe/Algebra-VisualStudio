using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati_primjer
{
    public delegate void TestDelegat(string poruka);
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDelegat del = KlasaA.MetodaA;
            del("Pozdrav A");

            del = KlasaB.MetodaB;
            del("Pozdrav B");

            del = (string poruka) => Console.WriteLine("Pozvan preko Lambda izraza: " + poruka);
            del("Dellboy");
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
