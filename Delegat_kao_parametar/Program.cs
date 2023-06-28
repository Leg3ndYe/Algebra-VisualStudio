using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_kao_parametar
{
    internal class Program
    {
        public delegate void TestDelegat(string poruka);
        static void Main(string[] args)
        {
            TestDelegat del = KlasaA.MetodaA;
            PozivanjeDelegata(del);

            del = KlasaB.MetodaB;
            PozivanjeDelegata(del);

            del = (string poruka) => Console.WriteLine("Pozvan preko Lambda izraza: " + poruka);
            PozivanjeDelegata(del);
            
        }
        static void PozivanjeDelegata(TestDelegat del)
        {
            del("Pozdrav svima");
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
