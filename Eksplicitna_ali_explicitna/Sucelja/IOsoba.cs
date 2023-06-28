using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksplicitna_ali_explicitna.Sucelja
{
    public interface IOsoba
    {
        string ImePrezime { get; }
        int Godine { get; }
        string DohvatiImePrezime();
    }
}
