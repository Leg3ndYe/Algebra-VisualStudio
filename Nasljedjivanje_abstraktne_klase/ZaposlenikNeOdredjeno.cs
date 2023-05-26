using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_abstraktne_klase
{
    class ZaposlenikNeOdredjeno : Zaposlenik
    {
        public decimal MjesecnaPlaca { get; set; }
        public decimal PovecanjaPlace { get; set; }
        public string Status { get; } = "Zaposlen na neodredjeno.";
        public override decimal Placa()
        {
            return MjesecnaPlaca + PovecanjaPlace;
        }
    }
}
