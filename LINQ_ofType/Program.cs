using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ofType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            lista.Add(3);
            lista.Add(4);
            lista.Add("Algebra");
            lista.Add("C# i MVC");
            lista.Add(13);
            lista.Add(new Polaznik() { ID = 1, Ime = "Igor" });

            Console.WriteLine("===================================================");
            Console.WriteLine("Primjer s ofType - pronadji sve stringove: ");
            Console.WriteLine("===================================================");

            var string_rezultati = from s in lista.OfType<string>()
                                   select s;

            foreach(string s in string_rezultati)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("===================================================");
            Console.WriteLine("Primjer s ofType - pronadji sve brojeve: ");
            Console.WriteLine("===================================================");

            var int_rezultati = from i in lista.OfType<int>()
                                select i;

            foreach (int i in int_rezultati)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("===================================================");
            Console.WriteLine("Primjer s ofType - pronadji sve stringove, s method syntax stilom: ");
            Console.WriteLine("===================================================");

            var string_rezultati_methodsyntax = lista.OfType<string>();

            foreach(var s in string_rezultati_methodsyntax) { Console.WriteLine(s); }
        }

    }
    public class Polaznik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
    }
}
