using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_overloading
{
    internal class Program
    {
        static int Mnozenje (int a, int b)
        {
            return a * b;
        }

        static int Mnozenje (int a, int b, int c) 
        {
            return a * b * c;
        }

        static int Mnozenje(int a, int b, int c, int d)
        {
            return a * b * c * d;
        }

        static string Mnozenje (string tekst, int puta)
        {
            string rez = "";
            for (int i = 0; i < puta; i++)
            {
                rez = rez + tekst + " ";
            }
            return rez;
        }
        static float Mnozenje(float a, float b) 
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Mnozenje dva broja: " + Mnozenje(2, 3));
            Console.WriteLine("Mnozenje tri broja: " + Mnozenje(2, 7, 13));
            Console.WriteLine("Mnozenje cetiri broja: " + Mnozenje(5, 9, 2, 1));
            Console.WriteLine(Mnozenje("test", 12));
            Console.WriteLine("Mnozenje dva broja: " + Mnozenje(2.2f, 3.3f));
            Console.WriteLine();
            
        }

    }
}
