using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimne_metode_primjer
{
    public delegate void Printaj(int vrijednost);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Anonimne metode - jednostavna anonimna metoda");
            Console.WriteLine("=============================================");
            Console.WriteLine();

            Printaj printer = delegate (int broj)
            {
                Console.WriteLine("Ja sam unutar anonimne metode s brojem: " + broj);
            };

            printer(69);

            Console.WriteLine();
            Console.WriteLine("=============================================");
            Console.WriteLine("Anonimne metode - primjer s varijablom");
            Console.WriteLine("=============================================");
            Console.WriteLine();

            int i = 13;

            printer = delegate (int broj)
            {
                broj += i;
                Console.WriteLine("Nazalim se u anonimnoj metodi s brojem "+broj);
            };
            printer(69);

            Console.WriteLine();
            Console.WriteLine("=============================================");
            Console.WriteLine("Anonimne metode - metoda kao parametar");
            Console.WriteLine("=============================================");
            Console.WriteLine();

            PrintajHelperMetoda(
                delegate(int broj) { Console.WriteLine("Anonimna metoda " + broj); },
                39
                );
        }
        public static void PrintajHelperMetoda(Printaj printerDelegat, int broj)
        {
            broj++;
            printerDelegat(broj);
        }
    }
}
