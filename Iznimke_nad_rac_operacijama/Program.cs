using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_nad_rac_operacijama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rezultat;
            float broj;

            Console.Write("Unesite broj: ");
            try
            {
                broj = Convert.ToSingle(Console.ReadLine());

                rezultat = (float)Math.Sqrt(broj);
                Console.WriteLine("Rezultat je " + rezultat.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Ne mogu korijenovati!");
            }


        }
    }
}
