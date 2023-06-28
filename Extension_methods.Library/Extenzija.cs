using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods.Library
{
    public static class Extenzija
    {
        public static void DodatnaMetodaEkstenzije(this ObicnaKlasa o)
        {
            Console.WriteLine("Ja sam prosirenje obicne klase!");
        }
    }
}
