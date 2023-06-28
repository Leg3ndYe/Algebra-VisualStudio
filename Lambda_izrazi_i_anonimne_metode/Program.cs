using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_i_anonimne_metode
{
    internal class Program
    {
        public class AsinkronaKlasa
        {
            public string Pozdrav(string ime)
            {
                return ime;
            }

            public async Task<string> Pozdrav()
            {
                return await Task.Run(() =>
                {
                    Func<string, string> del = x => x;
                    return del.Invoke("Ne znam kako se zovem!");
                });
            }

            public async void Zabava()
            {
                Console.WriteLine(await Pozdrav());
            }
        }
        static void Main(string[] args)
        {
            new AsinkronaKlasa().Zabava();

            Console.ReadKey();
        }
    }
}
