using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_sa_svojstvima_klase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Polaznik> detalji = new List<Polaznik>()
            {
                new Polaznik() { ID = 1, Ime = "Nikola", Prezime = "Tesla"},
                new Polaznik() { ID = 2, Ime = "Bill", Prezime = "Gates", Status_polaznika = false},
                new Polaznik() { ID = 3, Ime = "Josip", Prezime = "Jelacic"},
                new Polaznik() { ID = 4, Ime = "Marko", Prezime = "Marulic", Status_polaznika=false},
                new Polaznik() { ID = 5, Ime = "Ivana", Prezime = "Brlic-Mazuranic"}
            };

            var sortirana_lista = detalji.OrderBy(x => x.Prezime);
            Console.WriteLine("Sortirani podaci: ");
            foreach(var item in sortirana_lista)
            {
                Console.WriteLine(item.ID + " " + item.Prezime + " " + item.Ime);
            }

            var detalji_s_inicijalima = detalji.Select(x => new
            {
                Id = x.ID,
                SlovoImena = x.Ime[0],
                SlovoPrezimena = x.Prezime[0]
            });

            Console.WriteLine();
            Console.WriteLine("Detalji s inicijalima: ");
            foreach(var item in detalji_s_inicijalima)
            {
                Console.WriteLine(item);
            }

            var samo_aktivni = detalji.Where(x => x.Status_polaznika == true);

            Console.WriteLine();
            Console.WriteLine("Aktivni polaznici: ");
            foreach(var item in samo_aktivni)
            {
                Console.WriteLine(item.ID + " " + item.Ime + " "+ item.Prezime);
            }
        }
    }
}
