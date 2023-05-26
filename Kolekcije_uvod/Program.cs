using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer deklaracije i inicijalizacije ArrayList: ");
            Console.WriteLine();

            ArrayList lista_brojeva = new ArrayList();

            lista_brojeva.Add(13);
            lista_brojeva.Add(666);
            lista_brojeva.Add(3.14F);
            lista_brojeva.Add(1234567890);

            Console.WriteLine(lista_brojeva[0]);
            Console.WriteLine(lista_brojeva[2]);

            Console.WriteLine();

            var lista_razlicitih_podatak = new ArrayList();

            lista_razlicitih_podatak.Add("Nikola Tesla");
            lista_razlicitih_podatak.Add(300);
            lista_razlicitih_podatak.Add(false);
            lista_razlicitih_podatak.Add(null);

            var lista_razlicitih_podataka_2 = new ArrayList() { "Zastava", "Yugo", 45, "Tesla", true, null, 2.72f };
            lista_razlicitih_podataka_2.Add("bla bla bla");
            foreach (var i in lista_razlicitih_podataka_2)
            {
                Console.WriteLine(i);
            }

            lista_razlicitih_podataka_2.Remove(null);
            lista_razlicitih_podataka_2.RemoveAt(1);

            Console.WriteLine("=======================================");
            Console.WriteLine("Genericke kolekcije: ");
            Console.WriteLine();

            List<int> brojevi = new List<int>();
            brojevi.Add(1);
            brojevi.Add(13);
            brojevi.Add(69);

            foreach(int i in brojevi)
            {
                Console.WriteLine(brojevi);
            }

            List<string> tekstovi = new List<string>();
            List<bool> boolovi = new List<bool>();
            List<ArrayList> lista_listi = new List<ArrayList>();
        }
    }
}
