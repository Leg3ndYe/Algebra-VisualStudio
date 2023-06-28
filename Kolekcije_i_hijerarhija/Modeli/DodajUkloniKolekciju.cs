using Kolekcije_i_hijerarhija.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_i_hijerarhija.Modeli
{
    public class DodajUkloniKolekciju<T> : DodajKolekciju<T>, IDodajUkloniKolekciju<T>
    {
        private const int IndexDodavanjaNovogElementa = 0;
        public virtual T Ukloni()
        {
            return this.Podaci.Pop();
        }
        public override int Dodaj(T element)
        {
            this.Podaci = new Stack<T>(new T[] { element }.Concat(this.Podaci.Reverse()));
            return IndexDodavanjaNovogElementa;
        }
    }
}
