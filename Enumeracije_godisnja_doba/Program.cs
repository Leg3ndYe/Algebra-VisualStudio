using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije_godisnja_doba
{
    public enum GodisnjaDoba
    {
        Proljece,
        Ljeto,
        Jesen,
        Zima
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GodisnjaDoba doba = GodisnjaDoba.Proljece;
            Console.Write("Unesite godisnje doba: ");
            string gdoba = Console.ReadLine();
            switch(gdoba.ToLower())
            {
                case "proljece":
                    doba = GodisnjaDoba.Proljece;
                    break;

                case "ljeto":
                    doba = GodisnjaDoba.Ljeto;
                    break;

                case "jesen":
                    doba = GodisnjaDoba.Jesen;
                    break;

                case "zima":
                    doba = GodisnjaDoba.Zima;
                    break;
            }
            Console.WriteLine("Vrijednost {0} je {1}",doba,(int)doba);
            var ran = new Random();
            doba = (GodisnjaDoba)ran.Next(0, 3);
            Console.WriteLine(doba);
        }
    }
}
