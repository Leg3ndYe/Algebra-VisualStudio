using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_zivotinja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var zivotinja = DohvatiZivotinje();
            Console.WriteLine();
            foreach(var z in zivotinja)
            {
                Console.WriteLine(z);
            }
        }
        private static List<Zivotinja> DohvatiZivotinje()
        {
            var zivotinje = new List<Zivotinja>();
            do
            {
                Console.Write("Unesite vrstu zivotinje (unesite \"kraj\" za prekid) : ");
                string vrsta = Console.ReadLine();
                if (vrsta == "kraj") break;
                Console.Write("Unesite naziv zivotinje: ");
                string naziv = Console.ReadLine();
                Console.Write("Unesite godinu zivotinje: ");
                int godine = Convert.ToInt32(Console.ReadLine());
                Console.Write("Unesite spol zivotinje: ");
                string spol = Console.ReadLine();

                try
                {
                    var zivotinja = VrsteZivotinja.PronadjiZivotinju(vrsta.ToLower(), naziv, godine, spol);
                    zivotinje.Add(zivotinja);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message); 
                }
            } while (true);

            return zivotinje;
        }
    }
}
