using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati_genericki
{
    public delegate T plus<T> (T parametar1, T parametar2);
    internal class Program
    {
        static void Main(string[] args)
        {
            plus<int> zbr = Zbroj;
            Console.WriteLine(zbr(666, 69));

            plus<string> str = Konkatenacija;
            Console.WriteLine(str("Number of ","the Beast!"));

        }

        public static int Zbroj(int broj1, int broj2)
        {
            return broj1 + broj2;
        }

        public static string Konkatenacija(string s1, string s2)
        {
            return s1 + s2; 
        }
    }
}
