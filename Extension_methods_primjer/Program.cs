using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods_primjer
{
    public static class Extenzije
    {
        public static bool JeVeciOd(this int i, int j)
        {
            return i > j;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            bool rez = i.JeVeciOd(100);

            Console.WriteLine(rez);
        }
    }
}
