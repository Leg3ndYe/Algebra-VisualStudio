using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimne_metode_i_delegati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Zaposlenik> lista_zaposlenika = new List<Zaposlenik>()
            {
                new Zaposlenik{ID = 101, Ime = "Miljenko", Spol = "M", Placa = 1500},
                new Zaposlenik{ID = 102, Ime = "Ivanka", Spol = "Z", Placa = 1300},
                new Zaposlenik{ID = 103, Ime = "Kresimir", Spol = "M", Placa = 1800},
                new Zaposlenik{ID = 104, Ime = "Branko", Spol = "M", Placa = 1250}
            };

            Zaposlenik zap = lista_zaposlenika.Find(
                delegate (Zaposlenik x)
                {
                    return x.ID == 103;
                }
            );
            // MNOGO MNOGO BOLJE Zaposlenik zap2 = lista_zaposlenika.Find(x => x.ID == 103);
            Console.WriteLine(zap.ID.ToString()+" "+zap.Ime+" "+zap.Spol);
        }
    }
    public class Zaposlenik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Spol { get; set; }
        public double Placa { get; set; }
    }
}
