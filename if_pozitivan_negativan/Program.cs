using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_pozitivan_negativan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Unesite broj: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x > 0) 
            {
                Console.WriteLine(x+ " je pozitivan.");
            }
            else if (x < 0) 
            {
                Console.WriteLine(x + " je negativan.");
            }
            else
            {
                Console.WriteLine("Unio si nulu... koja nije ni pozitivna ni negativna \n" +
                    "osim ako mislis drugacije.. to je tvoja stvar.");
            }
        }
    }
}
