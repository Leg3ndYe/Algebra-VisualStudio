using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimne_metode_i_vanjske_varijable
{
    internal class Program
    {
        delegate void DelegatBrojacTipova();

        static DelegatBrojacTipova KreirajBrojac(string nazivBrojaca)
        {
            int brojac = 0;
            DelegatBrojacTipova del = delegate
            {
                Console.WriteLine(nazivBrojaca + (++brojac).ToString());
            };
            return del;
        }
        static void Main(string[] args)
        {
            DelegatBrojacTipova brojacA = KreirajBrojac("Brojac A: ");
            DelegatBrojacTipova brojacB = KreirajBrojac("Brojac B: ");

            brojacA();
            brojacA();
            brojacB();
            brojacB();
        }
    }
}
