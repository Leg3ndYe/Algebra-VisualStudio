using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_piramida_brojeva
{  
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obrazac piramide s brojevima uvecanim za 1: ");
            Console.WriteLine();
            Console.WriteLine();

            int redova, razmak, t = 0;
            Console.WriteLine("Unesite broj redova: ");
            redova = Convert.ToInt32(Console.ReadLine());
            razmak = redova + 4 - 1;

            for (int i = 1; i<= redova; i++) 
            {
                for (int k = razmak; k>= 1; k--)
                {
                    Console.Write(" ");
                } 

                for (int j = 1; j < i; j++)
                {
                    if (t < 10) { Console.Write(" "); }
                    else if(t<100) { Console.Write(""); }
                    Console.Write(t + " ");
                    t++;
                   
                }
                Console.WriteLine();
                razmak--;
            }
        }
    }
}
