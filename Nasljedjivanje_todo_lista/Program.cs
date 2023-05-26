using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_todo_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista moja_lista = new Lista();
            moja_lista.Dodaj("Gaming", "Zelim uc u platinum!");
            do
            {
                moja_lista.NovaStavka();
                Console.WriteLine();
                Console.Write("Zelite li daljnji unos? (d/n)");
                string odgovor = Console.ReadLine();
                if (odgovor.ToLower() != "d") break;
            } while (true);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            moja_lista.IspisListe();

        }
    }
}
