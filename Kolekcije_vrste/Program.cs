using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_vrste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList alista = new ArrayList();
            alista.Add(12);
            alista.Add("neki niz");
            alista.Add(new Program());

            List<int> lista_brojeva = new List<int>();
            Queue<int> red_brojeva = new Queue<int>();
            Stack<int> stack_brojeva = new Stack<int>();
            Dictionary<int, string> parovi_rijeci = new Dictionary<int, string>();
            
            Random r = new Random();
            for(int i = 0; i < 20; i++)
            {
                int broj = r.Next();
                lista_brojeva.Add(broj);
                red_brojeva.Enqueue(broj);
                stack_brojeva.Push(broj);
                parovi_rijeci.Add(broj, broj.ToString());
            }
            int broj_za_maknut = r.Next();
            lista_brojeva.Remove(broj_za_maknut);
            lista_brojeva.RemoveAt(1);

            int rez = red_brojeva.Dequeue();
            rez = stack_brojeva.Pop();
            parovi_rijeci.Remove(broj_za_maknut);

            Dictionary<string, string> rijecnik_en = new Dictionary<string, string>();
            Dictionary<string, string> rijecnik_de = new Dictionary<string, string>();
            rijecnik_en.Add("podaci", "data");
            rijecnik_de.Add("podaci", "datai");

        }
    }
}
