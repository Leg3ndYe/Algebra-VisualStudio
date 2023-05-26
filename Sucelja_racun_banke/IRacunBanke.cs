using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_racun_banke
{
    internal interface IRacunBanke
    {
        void Isplata(decimal iznos);
        void Uplata(decimal iznos);
        string IspisiSaldo();
        decimal Saldo { get; }
    }
}
