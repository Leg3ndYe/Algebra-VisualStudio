using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_jednostavni
{
    public delegate void DelegateEventHandler();
    internal class Program
    {
        public static event DelegateEventHandler Dodaj;
        static void Main(string[] args)
        {
            Dodaj += new DelegateEventHandler(Njemacka);
            Dodaj += new DelegateEventHandler(Filipini);
            Dodaj += new DelegateEventHandler(Ukrajina);

            Dodaj.Invoke();
        }

        static void Njemacka()
        {
            Console.WriteLine("Njemacka");
        }

        static void Filipini()
        {
            Console.WriteLine("Filipini");
        }
        static void Ukrajina()
        {
            Console.WriteLine("Ukrajina");
        }
    }
}
