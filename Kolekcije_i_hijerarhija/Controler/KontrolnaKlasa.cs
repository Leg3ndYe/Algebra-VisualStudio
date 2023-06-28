using Kolekcije_i_hijerarhija.Modeli;
using Kolekcije_i_hijerarhija.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_i_hijerarhija.Controler
{
    public class KontrolnaKlasa
    {
        private IDodajKolekciju<string> dodaj_kolekciju;
        private IDodajUkloniKolekciju<string> dodaj_ukloni_kolekciju;
        private IMojaLista<string> moja_lista;
        private StringBuilder rezultat_za_ispis;

        public KontrolnaKlasa()
        {
            this.dodaj_kolekciju = new DodajKolekciju<string>();
            this.dodaj_ukloni_kolekciju = new DodajUkloniKolekciju<string>();
            this.moja_lista = new MojaLista<string>();
            this.rezultat_za_ispis = new StringBuilder();
        }

        public void PokreniProces()
        {
            Console.Write("Unesite nekoliko rijeci ili duzu recenicu: ");
            var input = Console.ReadLine().Split();
            this.PopuniKolekciju(ref input, this.dodaj_kolekciju);
            this.PopuniKolekciju(ref input, this.dodaj_ukloni_kolekciju);
            this.PopuniKolekciju(ref input, this.moja_lista);

            Console.Write("Unesite broj elemenata za uklanjanje: ");
            var broj = int.Parse(Console.ReadLine());
            this.OperacijaUklanjanja(broj, this.dodaj_ukloni_kolekciju);
            this.OperacijaUklanjanja(broj, this.moja_lista);

            Console.WriteLine(this.rezultat_za_ispis.ToString().Trim());
        }
        
        private void OperacijaUklanjanja<T>(int broj_elemenata_za_uklanjanje, IDodajUkloniKolekciju<T> kolekcija)
        {
            while(broj_elemenata_za_uklanjanje > 0)
            {
                var uklonjenElement = kolekcija.Ukloni();
                this.rezultat_za_ispis.Append($" {uklonjenElement} ");
                broj_elemenata_za_uklanjanje--;
            }
            this.rezultat_za_ispis.Remove(this.rezultat_za_ispis.Length - 1, 1).AppendLine();
        }

        private void PopuniKolekciju(ref string[] input, IDodajKolekciju<string> kolekcija)
        {
            foreach(var str in input)
            {
                var index = kolekcija.Dodaj(str);
                this.rezultat_za_ispis.Append($" {index} ");
            }
            this.rezultat_za_ispis.Remove(this.rezultat_za_ispis.Length-1,1).AppendLine();
        }
    }
}
