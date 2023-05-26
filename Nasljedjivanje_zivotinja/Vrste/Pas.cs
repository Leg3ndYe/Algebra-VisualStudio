using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_zivotinja.Vrste
{
    internal class Pas : Zivotinja
    {
        public Pas(string naziv, int godine, string spol) : base(naziv, godine, spol)
        {
        }

        public override string KakoSeGlasa()
        {
            return "wuf wuf";
        }
    }
}
