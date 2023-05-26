using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_abstraktne_klase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izvjesce o placama: ");
            Console.WriteLine();

            ZaposlenikNeOdredjeno z1 = new ZaposlenikNeOdredjeno();
            z1.ID_Zaposlenika = 1010;
            z1.Ime = "Danijel";
            z1.Prezime = "Pobi";
            z1.Vrsta_Posla = "Programer";
            z1.MjesecnaPlaca = 1213.96m;
            z1.PovecanjaPlace = z1.MjesecnaPlaca / 5;
            Print(z1.ID_Zaposlenika, z1.PunoIme(), z1.Vrsta_Posla, z1.Status, z1.Placa());

            ZaposlenikUgovorODjelu z2 = new ZaposlenikUgovorODjelu();
            z2.ID_Zaposlenika = 5353;
            z2.Ime = "Lukas";
            z2.Prezime = "Mazan";
            z2.Vrsta_Posla = "Student";
            z2.BrojRadnihDana = 20;
            z2.CijenaPoSatu = 7.3M;
            Print(z2.ID_Zaposlenika, z2.PunoIme(), z2.Vrsta_Posla, z2.Status, z2.Placa());
        }

        public static void Print(int id, string punoime, string posao, string status, decimal placa)
        {
            Console.WriteLine("ID zaposlenika: " + id);
            Console.WriteLine("Zaposlenik: " + punoime);
            Console.WriteLine("Vrsta posla: " + posao);
            Console.WriteLine("Status: " + status);
            Console.WriteLine("Placa: " + Math.Round(placa,2));

        }
    }
}
