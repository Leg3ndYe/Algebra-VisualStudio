using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Diagnostics;
using System.Text.Json;
using System.Net.Http;
using System.Net;

namespace Serializacija_primjer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Polaznik p = new Polaznik();
            p.ID = 1;
            p.Ime = "Danijel";


            //BINARNI FORMAT:
            //IFormatter formater = new BinaryFormatter();
            //Stream pohrani = new FileStream("primjer.txt", FileMode.Create, FileAccess.Write);

            //formater.Serialize(pohrani, p);
            //pohrani.Close();

            //Stream citaj = new FileStream("primjer.txt", FileMode.Open, FileAccess.Read);
            //Polaznik novi = (Polaznik)formater.Deserialize(citaj);

            //Console.WriteLine(novi.ID);
            //Console.WriteLine(novi.Ime);



            //XML:
            //XmlDocument doc = new XmlDocument();

            //XmlWriter xmlwrite = XmlWriter.Create("polaznik.xml");
            //xmlwrite.WriteStartDocument();
            //xmlwrite.WriteStartElement("polaznici");

            //xmlwrite.WriteStartElement("polaznik");
            //xmlwrite.WriteAttributeString("ID", p.ID.ToString());
            //xmlwrite.WriteAttributeString("Ime", p.Ime);
            //xmlwrite.WriteEndElement();

            //xmlwrite.WriteEndElement();
            //xmlwrite.WriteEndDocument();
            //xmlwrite.Close();

            //doc.Load("polaznik.xml");
            //Console.WriteLine(doc.InnerXml);



            //JSON:
            //string json = JsonSerializer.Serialize(p);
            //File.WriteAllText("polaznik.json", json);
            //Console.WriteLine(json);

            //string procitano = File.ReadAllText("polaznik.json");

            //Polaznik novi_polaznik = JsonSerializer.Deserialize<Polaznik>(json);
            //Console.WriteLine(novi_polaznik.ID);
            //Console.WriteLine(novi_polaznik.Ime);



            //Dohvacanje podataka sa servera
            HttpClient httpClient = new HttpClient();
            var task = httpClient.GetStringAsync("https://api.hnb.hr/tecajn-eur/v3?valuta=AUD");
            var poruka = await task;
            Console.WriteLine(poruka);
        }
    }
}
