using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_i_operatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cs_je_zanimljiv = true;
            bool trava_je_roza = false;

            Console.WriteLine("============================");

            Console.WriteLine("Primjer ispisa boolean vrijednosti: ");
            Console.WriteLine(cs_je_zanimljiv);
            Console.WriteLine(trava_je_roza);

            Console.WriteLine("============================");

            int x = 1;
            int y = 3;
            Console.WriteLine("Primjer s operatorima usporedbe: ");
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);   
            Console.WriteLine(x == y);
            Console.WriteLine(x = y);

            Console.WriteLine("============================");

            Console.WriteLine("Primjer rada logickih operatora: ");
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine();
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);
            Console.WriteLine();
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);


        }
    }
}
