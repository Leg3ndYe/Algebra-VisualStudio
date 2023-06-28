using Kolekcije_i_hijerarhija.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_i_hijerarhija.Modeli
{
    public class MojaLista<T> : DodajUkloniKolekciju<T>, IMojaLista<T>
    {
        public IReadOnlyCollection<T> Used
        {
            get
            {
                return this.Podaci as IReadOnlyCollection<T>;
            }
        }
        public override T Ukloni()
        {
            var prvi_elemnt = this.Podaci.Last();
            this.Podaci = new Stack<T>(this.Podaci.Take(this.Podaci.Count-1).Reverse());
            return prvi_elemnt;
        }
    }
}
