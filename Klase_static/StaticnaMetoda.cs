using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_static
{
    class StaticnaMetoda
    {
        public static bool Prost(int broj)
        {
            for(int i = 2; i < broj; i++)
            {
                if (broj % i == 0) return false;
            }
            return true;
        }
        public bool Savrsen(int broj)
        {
            int zbroj = 0;
            for(int i = 1; i < broj; i++)
            {
                if(broj % i == 0)
                {
                    zbroj += i;
                }
            }
            if (zbroj == broj) return true;
            else return false;
        }
    }
}
