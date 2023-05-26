using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije_petlje
{
    enum DaniUTjednu
    {
        Ponedjelja = 1,
        Utorak,
        Srijeda,
        Cetvrtak,
        Petak,
        Subota,
        Nedjelja
    }
    enum Mjeseci
    {
        Sijecanj = 1,
        Veljaca,
        Ozujak,
        Travanj,
        Svibanj,
        Lipanj,
        Srpanj,
        Kolovoz,
        Rujan,
        Listopad,
        Studeni,
        Prosinac

    }
    enum Boje
    {
        Crvena,
        Zelena,
        Plava,
        Crna,
        Bijela,
        Roza
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Citanje vrijednosti nabrajanja Boja: ");
            foreach(int i in Enum.GetValues(typeof(Boje)))
            {
                Console.WriteLine("{0} {1}", i, (Boje)i);
            }

            Console.WriteLine();

            foreach(var z in Enum.GetNames(typeof(Mjeseci)))
            {
                Console.WriteLine(z);
            }

            Console.WriteLine();
            Console.WriteLine(DaniUTjednu.Petak.ToString());
            Console.WriteLine(DaniUTjednu.Petak);
        }
    }
}
