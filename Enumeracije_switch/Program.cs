using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije_switch
{
    enum Razina
    {
        Nisko,
        Srednje,
        Visoko,
        Prelilo
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Razina vodostaj = Razina.Nisko;

            switch(vodostaj)
            {
                case Razina.Nisko:
                    Console.WriteLine("Niska razina, slabo ce se pecati!");
                    break;
                case Razina.Srednje:
                    Console.WriteLine("Srednja razina, sve oke.");
                    break;
                case Razina.Visoko:
                    Console.WriteLine("Visoka razina, oprez s malo mutnom vodom i nanosima.");
                    break;
                case Razina.Prelilo:
                    Console.WriteLine("Poplava, pojacaj nasipe.");
                    break;
            }
        }
    }
}
