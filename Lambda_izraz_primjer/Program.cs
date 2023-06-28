using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izraz_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>() {36, 71, 12, 15, 29, 18, 17, 27, 9, 34, 13, 69};

            Console.WriteLine("Lista brojeva: ");
            foreach(int i in brojevi)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            var kvadrati_brojeva = brojevi.Select(x => x * x);

            Console.WriteLine("Kvadrati brojeva: ");
            foreach (int i in kvadrati_brojeva)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            var djeljivi_s_3 = brojevi.FindAll(a => a % 3 == 0);

            Console.WriteLine("Brojevi djeljivi s 3: ");
            foreach (int i in djeljivi_s_3)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            var prosti_brojevi = brojevi.FindAll(x => prost(x));
            Console.WriteLine("Prosti brojevi: ");
            foreach (int i in prosti_brojevi)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            bool prost(int n)
            {
                for(int i = 2; i < n; i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }
        }

      
     
    }
}
