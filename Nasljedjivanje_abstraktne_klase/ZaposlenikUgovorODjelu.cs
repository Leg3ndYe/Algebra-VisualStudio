using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_abstraktne_klase
{
    class ZaposlenikUgovorODjelu : Zaposlenik
    {
        public short BrojRadnihDana { get; set; }
        public decimal CijenaPoSatu { get; set; }
        public string Status { get; } = "Zaposlen preko ugovora o djelu.";
        public override decimal Placa()
        {
            return BrojRadnihDana*CijenaPoSatu*8;
        }
        public override string ToString()
        {
            return base.PunoIme();
        }
    }
}
