using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksplicitna_ali_explicitna.Sucelja
{
    public interface IStanovnik
    {
        string ImePrezime { get; }
        string Drzava { get; }
        string DohvatiImePrezime();
    }
}
