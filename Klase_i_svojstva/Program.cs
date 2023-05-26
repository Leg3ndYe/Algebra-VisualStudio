using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_svojstva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Osoba o1 = new Osoba("12345678901");
                o1.Ime = "Nikola";

                string ime = o1.Ime;

                o1.Starost = 45;
                o1.Starost = -2;
            }
            catch (Exception ex)
            {
                if(ex.Message == "Starost mora biti veca od 0!!")
                {
                    Console.WriteLine("Upisali ste nedozvoljenu dob!");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }
            finally
            {
                Console.WriteLine("Gotovo s osobama!! ");
            }

            Racunalo pc1 = new Racunalo(16);

            Racunalo pc2 = new Racunalo("AMD", 32, 5000);

        }
    }
}
