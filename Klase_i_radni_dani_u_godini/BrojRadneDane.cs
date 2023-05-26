using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_radni_dani_u_godini
{
    class BrojRadneDane
    {
        public int PronadjiRadneDane(DateTime poc, DateTime kraj)
        {
            int radni_dani = 0;

            for(DateTime i = poc; i <= kraj; i = i.AddDays(1))
            {
                if(JeRadniDan(i))
                {
                    radni_dani++;
                }
            }

            return radni_dani;
        }
        public bool JeRadniDan(DateTime dan)
        {
            if(dan.DayOfWeek == DayOfWeek.Sunday || dan.DayOfWeek == DayOfWeek.Saturday) 
            {
                return false;
            }

            DateTime[] praznici = new DateTime[]
            {
                new DateTime(1, 1, 1),
                new DateTime(1, 1, 6),
                new DateTime(1, 5, 1),
                new DateTime(1, 5, 30),
                new DateTime(1, 6, 22),
                new DateTime(1, 8, 15),
                new DateTime(1, 11, 1),
                new DateTime(1, 12, 24),
                new DateTime(1, 12, 25),
                new DateTime(1, 12, 26),
            };
            for(int i= 0; i < praznici.Length; i++)
            {
                if(dan.Day == praznici[i].Day && dan.Month == praznici[i].Month)
                {
                    return false;
                }
            }
            return true;    
        }
    }
}
