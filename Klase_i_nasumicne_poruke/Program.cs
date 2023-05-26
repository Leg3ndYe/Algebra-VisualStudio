using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_nasumicne_poruke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj prikaza nasumicnih poruka: ");
            int broj = int.Parse(Console.ReadLine());
            IspisNasumicnihPorka(broj);
        }
        private static void IspisNasumicnihPorka(int broj)
        {
            string[] nasolvi = new string[]
            {
                "Odlican proizvod!",
                "Jako dobar proizvod!",
                "Uvijek koristim taj proizvod!",
                "Najbolji proizvod u svojoj kategoriji!",
                "Fenomenalan proizvod!",
                "Ne mogu zivjeti bez ovoga!"
            };
            string[] opisi = new string[]
            {
                "Sad se osjecam dobro s ovime!",
                "Uspio sam s ovim proizvodom rjesiti svoje probleme.",
                "Cini cuda, sretan sam zbog ovih rezultata.",
                "Ne mogu vjerovati ali sad se osjecam odlicno.",
                "Isprobajte sami, vrlo sam zadovoljan.",
                "Osjecam se sjajno!"
            };
            string[] autori = new string[]
            {
                "Mato",
                "Ivo",
                "Ana",
                "Martna",
                "Katarina",
                "Iva",
                "Anica",
                "Eva"
            };
            string[] gradovi = new string[]
            {
                "Rijeka",
                "Zagreb",
                "Split",
                "Osijek",
                "Karlovac"
            };

            Random rand = new Random();
            for(int i = 0; i < broj; i++)
            {
                Console.WriteLine($"{nasolvi[rand.Next(nasolvi.Length)]}, " +
                    $"{opisi[rand.Next(opisi.Length)]}, " +
                    $"{autori[rand.Next(autori.Length)]} " +
                    $"- {gradovi[rand.Next(gradovi.Length)]                                                                                                        }");
            }
        }
    }
}
                                                                                                                                                                                                                                    