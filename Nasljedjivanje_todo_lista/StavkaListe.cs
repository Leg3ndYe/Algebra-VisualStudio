using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_todo_lista
{
    class StavkaListe
    {
        #region Svojstva
        public int Broj { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public bool Gotovo { get; set; }
        #endregion

        #region Konstruktor

        public StavkaListe() { }

        public StavkaListe(string novi_naslov, string novi_opis) 
        {
            Naslov = novi_naslov;
            Opis = novi_opis;
            Gotovo = false;
        }

        public StavkaListe(int broj, string naslov, string opis, bool gotovo)
        {
            Broj = broj;
            Naslov = naslov;
            Opis = opis;
            Gotovo = gotovo;
        }


        #endregion
    }
}
