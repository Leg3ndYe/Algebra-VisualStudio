using Nasljedjivanje_zivotinja.Vrste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_zivotinja
{
    internal class VrsteZivotinja
    {
        public static Zivotinja PronadjiZivotinju(string vrsta, string naziv, int godine, string spol)
        {
            switch(vrsta)
            {
                case "pas":
                    return new Pas(naziv, godine, spol);
                case "macka":
                    return new Macka(naziv, godine, spol);
                case "krava":
                    return new Krava(naziv,godine,spol);
                default:
                    throw new ArgumentException("Neispravan unos!");
            }
        }
    }
}
