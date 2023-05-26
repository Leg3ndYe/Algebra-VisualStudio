using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_zivotinja.Vrste
{
    internal class Krava : Zivotinja
    {
        public Krava(string naziv, int godine, string spol) : base(naziv, godine, spol)
        {
        }

        public override string KakoSeGlasa()
        {
            return "muuuu";
        }
    }
}
