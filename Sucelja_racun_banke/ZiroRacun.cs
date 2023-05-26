using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_racun_banke
{
    class ZiroRacun : IRacunBanke
    {
        private decimal stanje_racuna;
        public decimal Saldo
        {
            get
            {
                return stanje_racuna;
            }
        }
        public string IspisiSaldo()
        {
           return "Stanje ziro racuna: " + Saldo + " eura.";
        }

        public void Isplata(decimal iznos)
        {
            if(stanje_racuna >= iznos)
            {
                stanje_racuna -= iznos;
            }
            else
            {
                Console.WriteLine("Nedovoljno sredstava na ziro racunu!");
            }
        }

        public void Uplata(decimal iznos)
        {
            stanje_racuna += iznos;
        }
    }
}
