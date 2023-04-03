using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_tipovi_pretvorbe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iCijeliBroj = 1;
            long lVelikiBroj = 2;
            double dDoubleBroj = 3.456;
            long lJakoVelikiBroj = 9999999999;

            Console.WriteLine("Implicitna pretvorba");
            Console.WriteLine("============================");

            lVelikiBroj = iCijeliBroj;
            Console.WriteLine(lVelikiBroj);

            dDoubleBroj = lVelikiBroj;
            Console.WriteLine(dDoubleBroj);

            lVelikiBroj = 2;
            dDoubleBroj = 3.456;

            Console.WriteLine();
            Console.WriteLine("Explicitna pretvorba");
            Console.WriteLine("============================");

            iCijeliBroj = (int)lVelikiBroj;
            Console.WriteLine(iCijeliBroj);

            lVelikiBroj = (long)dDoubleBroj;
            Console.WriteLine(lVelikiBroj);

            iCijeliBroj = (int)lJakoVelikiBroj;
            Console.WriteLine(iCijeliBroj);

        }
    }
}
