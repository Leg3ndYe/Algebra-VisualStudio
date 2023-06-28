using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serijalizacija_dodatni_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KorisnickiDetalji kd = new KorisnickiDetalji(1,"Nikola Tesla","Smiljani");

            Console.WriteLine("Prije serijalizacije objekt sadrzi sljedece podatke: ");
            kd.DohvatiDetalje();
            Console.WriteLine();

            string dat = "primjer.txt";

            if(File.Exists(dat) )
            {
                File.Delete(dat);
            }

            Stream pohrani = File.Open(dat, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(pohrani, kd);
            pohrani.Close();

            Console.WriteLine("Serijalizacija je bila uspjesna!");

            Stream otvori = File.Open(dat, FileMode.Open);
            bf = new BinaryFormatter();
            kd=(KorisnickiDetalji)bf.Deserialize(otvori);
            otvori.Close();

            Console.WriteLine();
            Console.WriteLine("Nakon deserijalizacije objekt sadrzi podatke: ");
            kd.DohvatiDetalje();

            Console.WriteLine();
            Console.WriteLine("Deserijalizacija je bila uspjesna!");
        }
    }
}
