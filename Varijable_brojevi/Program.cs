using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Varijable_brojevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short broj1 = -100;
            byte broj2 = 128;
            short broj3 = -3560;
            ushort broj4 = 64876;
            uint broj5 = 2147483648;
            int broj6 = -1141583217;
            long broj7 = -71263761647174612;

            Console.WriteLine($"{broj1}\n{broj2}\n{broj3}\n{broj4}\n{broj5}\n{broj6}\n{broj7}");
        }
    }
}
