using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_samoglasnici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provjera da li je uneseno slovo samoglasnik ili suglasnik");
            char slovo = Convert.ToChar(Console.ReadLine().ToLower());

            switch (slovo)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Unesen je samoglasnik!");
                    Console.WriteLine(slovo);
                    break;
                default:
                    if (slovo >= 'a' && slovo <= 'z') Console.WriteLine("Slovo je suglasnik");
                    else
                    {
                        Console.WriteLine("Nemam pojma sto je ovo {0}", slovo);
                    }
                    break;
            }
        }
    }
}
