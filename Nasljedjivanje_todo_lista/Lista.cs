using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_todo_lista
{
    class Lista : List<StavkaListe>
    {
        public Lista() { }

        public void Dodaj(string naslov, string opis)
        {
            int broj_zadatka = this.Count();
            int novi_broj = broj_zadatka + 1;

            this.Add(new StavkaListe(novi_broj, naslov, opis, false));
        }
        public void IspisListe()
        {
            Console.WriteLine();
            Console.WriteLine("Broj | Naslov | Opis");
            Console.WriteLine("---------------------");
            foreach(var t in this)
            {
                Console.WriteLine("{0}       {1}   {2}", t.Broj.ToString(), t.Naslov, t.Opis);
            }
        }

        public void NovaStavka()
        {
            string naslov = "";
            string opis = "";

            Console.WriteLine();
            Console.Write("Unesite naslov zadatka: ");
            naslov = Console.ReadLine();
            Console.Write("Unesite opis zadatka: ");
            opis = Console.ReadLine();

            this.Dodaj(naslov, opis);
        }
    }
}
