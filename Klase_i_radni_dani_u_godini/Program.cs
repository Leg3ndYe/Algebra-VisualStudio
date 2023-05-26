using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_radni_dani_u_godini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite pocetni datum: ");
            DateTime poc = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Unesite zavrsni datum: ");
            DateTime kraj = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            BrojRadneDane broji = new BrojRadneDane();
            Console.WriteLine("Radnih dana u periodu ima " + broji.PronadjiRadneDane(poc, kraj));
        }
    }
}
