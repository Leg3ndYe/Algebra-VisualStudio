using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serijalizacija.Library
{
    public class MetodeZaSerijalizaciju
    {
        public void SerijalizirajNesto()
        {
            KlasaZaSerijalizaciju[] kzs = new KlasaZaSerijalizaciju[3];
            kzs[0] = new KlasaZaSerijalizaciju();
            kzs[0].ImePrezime = "Milivoj Milivojic";
            kzs[0].Godine = 33;

            kzs[1] = new KlasaZaSerijalizaciju();
            kzs[1].ImePrezime = "Lana Lanic";
            kzs[1].Godine = 18;

            kzs[2] = new KlasaZaSerijalizaciju();
            kzs[2].ImePrezime = "Branko Brankic";
            kzs[2].Godine = 48;

            BinaryFormatter bf = new BinaryFormatter();
            Stream pohrani = new FileStream("podaci.txt", FileMode.Create, FileAccess.Write);
            bf.Serialize(pohrani, kzs);
            pohrani.Close();
        }

        public void DeserilizirajNesto()
        {
            KlasaZaSerijalizaciju[] kzs;

            BinaryFormatter bf = new BinaryFormatter();
            Stream citaj = new FileStream("podaci.txt", FileMode.Open, FileAccess.Read);
            kzs = (KlasaZaSerijalizaciju[])bf.Deserialize(citaj);
            citaj.Close();

            foreach(var item in kzs)
            {
                Console.WriteLine(item.ImePrezime + " " + item.Godine);
            }
            Console.WriteLine(KlasaZaSerijalizaciju.NazivTvrtke);
        }
    }
}
