using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_tipovi_i_hex_vrijednosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32("7B", 16);
            Console.WriteLine(i);
            Console.WriteLine(Convert.ToInt64("BABA", 16));
            Console.WriteLine(123.ToString("X"));
            Console.WriteLine(Convert.ToString(123456789, 2));
        }
    }
}
