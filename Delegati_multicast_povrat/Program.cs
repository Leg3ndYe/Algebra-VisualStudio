using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati_multicast_povrat
{
    public delegate int TestDelegat();
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDelegat del1 = KlasaA.MetodaA;
            TestDelegat del2 = KlasaB.MetodaB;

            TestDelegat del = del1 + del2;
            Console.WriteLine(del());
        }
    }

    public class KlasaA
    {
        public static int MetodaA()
        {
            return 666;
        }
    }

    public class KlasaB
    {
        public static int MetodaB()
        {
            return 69;
        }
    }

}
