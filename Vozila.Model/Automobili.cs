using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Automobili:System.Collections.CollectionBase
    {
        public void Add(Automobil noviAuto)
        {
            base.InnerList.Add(noviAuto);
        }
        public void Remove(Automobil automobilZaMaknuti)
        {
            base.InnerList.Remove(automobilZaMaknuti);
        }
        public bool Sadrzi(Automobil auto)
        {
            return base.InnerList.Contains(auto);
        }
    }
}
