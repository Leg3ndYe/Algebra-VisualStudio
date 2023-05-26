using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba("Marko", "Bozic", Spol.Muski);
            o.Spol = Spol.Nepoznato;

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Spol: " + o.Spol);
            int vrijednost = (int)o.Spol;
            Console.WriteLine("Vrijednost {0} je {1}", o.Spol, vrijednost);

            switch(o.Spol)
            {
                case Spol.Muski:
                    Console.WriteLine("Musko je!");
                    break;
                case Spol.Zenski:
                    Console.WriteLine("Zensko je.");
                    break;
                case Spol.Nepoznato:
                    Console.WriteLine(" :/ ");
                    break;
                    
            }
            o.Spol = (Spol)1;
            Console.WriteLine("Spol: " + o.Spol);

            //o.Spol = (Spol)6;
            //Console.WriteLine("Spol: " + o.Spol);

            o.Sprema = StrucnaSprema.PKV;
            Console.WriteLine("Strucna sprema {0} je {1}.",o.Sprema, (int)o.Sprema);

            Console.WriteLine("Ime: " + o.Ime);
            Console.WriteLine("Prezime: " + o.Prezime);
            Console.WriteLine("Spol: " + o.Spol);
            Console.WriteLine("Sprema: " + o.Sprema);
        }
    }
    enum Spol
    {
        Muski = 1,
        Zenski = 10,
        Nepoznato
    }
    enum StrucnaSprema
    {
        SSS,
        VSS,
        NKV,
        PKV
    }
}
