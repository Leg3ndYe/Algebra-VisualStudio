using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_racun_banke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime = "Nikola";
            string prezime = "Tesla";

            IRacunBanke tekuci = new TekuciRacun();
            IRacunBanke ziro = new ZiroRacun();

            Console.WriteLine(ime + " " + prezime);
            Console.WriteLine("Tekuci racun: ");

            tekuci.Uplata(240);
            Console.WriteLine(tekuci.IspisiSaldo());

            tekuci.Uplata(500);
            Console.WriteLine(tekuci.IspisiSaldo());

            tekuci.Isplata(1000);
            Console.WriteLine(tekuci.IspisiSaldo());

            tekuci.Isplata(200);
            Console.WriteLine(tekuci.IspisiSaldo());
            
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ziro racun: ");

            ziro.Uplata(550);
            Console.WriteLine(ziro.IspisiSaldo());

            ziro.Isplata(770);
            Console.WriteLine(ziro.IspisiSaldo());

            ziro.Isplata(125);
            Console.WriteLine(ziro.IspisiSaldo());



        }
    }
}
