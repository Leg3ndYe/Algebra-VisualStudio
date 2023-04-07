using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tekstualni_tipovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Danas je lijep i suncan dan?";
            Console.WriteLine(recenica);

            string abeceda = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("Duzina teksta varijable abecede je " + abeceda.Length + " znakova");

            string uredi_slova = "Ekipa, ajmo na pivo!";
            Console.WriteLine(uredi_slova.ToLower());
            Console.WriteLine(uredi_slova.ToUpper());

            string ime = "Nikola";
            string prezime = "Tesla";
            string ime_prezime = ime + " " + prezime;
            Console.WriteLine(ime_prezime);
            Console.WriteLine();

            char slovo1 = 'p';
            char slovo2 = 'e';
            char slovo3 = 't';
            char slovo4 = 'a';
            char slovo5 = 'k';

            Console.WriteLine("Danas je " + slovo1 + slovo2 + slovo3 + slovo4 + slovo5);
            Console.WriteLine();

            string spoji_slova_metoda = string.Concat(slovo1, slovo2, slovo3, slovo4, slovo5);
            Console.WriteLine(spoji_slova_metoda);

            Console.WriteLine("=================================");
            Console.WriteLine("Primjeri specijalnih znakova: ");
            Console.WriteLine();

            string teskt_s_navodnicima = "Treba cesce uzimati \"salatu\", \na pod tim mislimo na votku!";
            Console.WriteLine(teskt_s_navodnicima);

            string teskt_s_apostrofom = "Jesil' dobro?";
            Console.WriteLine(teskt_s_apostrofom);

            string tekst_s_backslash = "Ovaj znak \\ se zove backslash.";
            string tekst_s_backslash_literal = @"Ovaj znak \ se zove backslash.";
            Console.WriteLine(tekst_s_backslash);
            Console.WriteLine(tekst_s_backslash_literal);

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("Primjeri pretvorbe u string: ");
            Console.WriteLine();

            int cijeli_broj = 13;
            double decimalni_broj = 4.27;
            bool ok = true;

            Console.WriteLine(cijeli_broj.ToString());
            Console.WriteLine(decimalni_broj.ToString());
            Console.WriteLine(ok.ToString());

            Console.WriteLine();
            Console.WriteLine();

            string x = "22", y = "69";
            string zbroj = x + y;
            Console.WriteLine("Zbroj je " + zbroj);

            char i = '1';
            char j = '8';
            int zbroj_znakova = i + j;

            Console.WriteLine("Zbroj znakova je " + zbroj_znakova);

            int pretvori_i = (int)char.GetNumericValue(i);
            int pretvori_j = (int)char.GetNumericValue(j);
            int novi_zbroj = pretvori_i + pretvori_j;
            Console.WriteLine(novi_zbroj);

            Console.WriteLine("=================================");
            Console.WriteLine("Pomocne metode za string");

            Console.WriteLine(recenica);
            Console.WriteLine(recenica.ToUpper());
            Console.WriteLine(recenica.ToLower());

            Console.WriteLine(recenica.Substring(0, 5));
            Console.WriteLine(recenica.Substring(6, 5));

            Console.WriteLine(recenica.IndexOf('?'));
            Console.WriteLine(recenica.IndexOf(' '));
            Console.WriteLine(recenica.IndexOf(' ',6));
            Console.WriteLine(recenica.IndexOf('+'));

            
        }
    }
}
