using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_i_logika_jednakosti
{
    public class Osoba : IComparable<Osoba>
    {
        private string ime;
        private int dob;
        
        public Osoba(string ime, int godine)
        {
            this.ime = ime;
            this.Dob = godine;
        }
        public int Dob
        {
            set
            {
                dob = value;
                if(dob<0) dob = 0;
            }
            get { return dob; }
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public int CompareTo(Osoba druga_osoba)
        {
            var usporedba = this.Ime.CompareTo(druga_osoba.Ime);
            if(usporedba!=0) return usporedba;
            else return this.Dob.CompareTo(druga_osoba.Dob);
        }
    }
}
