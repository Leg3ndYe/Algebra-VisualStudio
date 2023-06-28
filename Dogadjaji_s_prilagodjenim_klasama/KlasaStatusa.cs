using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_s_prilagodjenim_klasama
{
    class KlasaStatusa:EventArgs
    {
        public bool Status_procesa { get; set; }
        public DateTime Vrijeme_zavrsetka { get; set; }


    }
}
