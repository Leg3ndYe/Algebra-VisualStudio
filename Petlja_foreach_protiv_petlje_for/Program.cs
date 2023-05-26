using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_foreach_protiv_petlje_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'A', 'l', 'g', 'e', 'b', 'r', 'a', ' ', 'i', ' ', 'A', 'S', 'P', '.', 'N', 'E', 'T' };

            Console.WriteLine("Ispis pomocu for: ");
            for(int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }

            Console.WriteLine("Ispis pomocu foreach: ");
            foreach(var c in chars)
            {
                Console.WriteLine(c);
            }


        }
    }
}
