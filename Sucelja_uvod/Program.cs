using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transakcija t = new Transakcija();
            t.Konekcija();
            t.NapraviTransakciju();
        }
    }

    interface ITransakcije
    {
        void NapraviTransakciju();
    }

    class KonekcijaBazaPodataka
    {
        public void Konekcija()
        {
            Console.WriteLine("Spojio sam se na bazu!");
        }
    }

    class Transakcija : KonekcijaBazaPodataka, ITransakcije, IComparable<Transakcija>
    {
        public int CompareTo(Transakcija other)
        {
            return 0;
        }

        public void NapraviTransakciju()
        {
            Console.WriteLine("Spajam se...");
        }

        
    }

}
