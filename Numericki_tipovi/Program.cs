using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numericki_tipovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cijelobrojni tipovi:
            int cijeli_broj = 5;
            int jos_veci_cijeli_broj = 1234567;
            long ogromni_broj = 1234567890123456789;

            Console.WriteLine("Cijeli brojevi: ");
            Console.WriteLine($"Tip int: {cijeli_broj}");
            Console.WriteLine($"Tip int: {jos_veci_cijeli_broj}");
            Console.WriteLine($"Tip long: {ogromni_broj}");

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine();

            //Decimalni brojevi:
            float float_broj = 3.66F;
            double double_broj = 123.56;
            decimal decimal_broj = 1234567.890123456789M;
            Console.WriteLine("Decimalni brojevi: ");
            Console.WriteLine($"Tip float: {float_broj}");
            Console.WriteLine($"Tip double: {double_broj}");
            Console.WriteLine($"Tip decimal: {decimal_broj}");

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine();

            //Pretvorba podatkovnih tipova

            //Implicitna pretvorba
            int implicitntni_broj = 11;
            double pretvori_u_double = implicitntni_broj;
            Console.WriteLine("Implicitno pretvaranje tipova: ");
            Console.WriteLine(implicitntni_broj);
            Console.WriteLine(pretvori_u_double);

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine();


            //Eksplicitna pretvorba
            double eksplicitni_broj = 23.91;
            int pretvori_u_int =(int)eksplicitni_broj;
            Console.WriteLine("Eksplicitno pretvaranje tipova: ");
            Console.WriteLine(eksplicitni_broj);
            Console.WriteLine(pretvori_u_int);

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine();

            //int u short
            int veliki_int = 345678;
            short short_broj = (short)veliki_int;
            Console.WriteLine("Eksplicitno pretvaranje tipova: ");
            Console.WriteLine(veliki_int);
            Console.WriteLine(short_broj);

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine();

            //Koristenje Convert metoda:
            int prvi_broj = 13;
            long drugi_broj = 12345678901234;
            float treci_broj = 3.14f;
            double cetvrti_broj = 56.098765;
            decimal peti_broj = 96666.99754412M;

        }
    }
}
