using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Odbc;
using System.IO;

namespace LINQ_to_SQL_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LINQ_to_SQL_uvod.Properties.Settings.linq_to_sqlConnectionString"].ConnectionString;

            LinqToSqlDataContext baza = new LinqToSqlDataContext(connectionString);

            while(true)
            {
                Console.WriteLine("Izbornik: ");
                Console.WriteLine("1. Popis zaposlenika.");
                Console.WriteLine("2. Unos novog zaposlenika.");
                Console.WriteLine("3. Azuriranje zaposlenika.");
                Console.WriteLine("4. Brisanje zaposlenika.");

                Console.WriteLine("0. Kraj programa.");
                Console.WriteLine();
                Console.Write("Vas odabir: ");
                int odabir = int.Parse(Console.ReadLine());

                if (odabir == 0) break;
                switch(odabir)
                {
                    case 1:
                        PopisZaposlenika(baza);
                        break;
                    case 2:
                        UnosNovogZaposlenika(baza);
                        break;
                    case 3:
                        Console.Write("Unesite sifru zaposlenika kojeg zelite azurirati: ");
                        odabir = int.Parse(Console.ReadLine());
                        AzurirajZaposlenika(baza, odabir);
                        break;
                    case 4:
                        Console.Write("Unesite sifru zaposlenika kojeg zelite obrisati: ");
                        odabir = int.Parse(Console.ReadLine());
                        BrisanjeZaposlenika(baza, odabir);
                        break;
                    default:
                        Console.WriteLine("Ne razumijem izbor, pokusajte ponovo.");
                        break;
                }
            }

        }
        static void UnosNovogZaposlenika(LinqToSqlDataContext baza)
        {
            Zaposlenik z = new Zaposlenik();
            Console.Write("Unesite Ime i Prezime zaposlenika: ");
            z.ImePrezime = Console.ReadLine();
            Console.Write("Unesite e-mail zaposlenika: ");
            z.Email = Console.ReadLine();
            Console.Write("Unesite telefon zaposlenika: ");
            z.Telefon = Console.ReadLine();
            Console.Write("Unesite adresu zaposlenika: ");
            z.Adresa = Console.ReadLine();

            var odjeli = baza.Odjels.ToList();
            string popisOdjela = "";
            foreach(var odjel in odjeli)
            {
                popisOdjela += odjel.ID + " - " + odjel.Naziv + ", ";
            }

            Console.Write($"Unesite sifru odjela: ({popisOdjela})");
            z.OdjelID = int.Parse(Console.ReadLine());

            baza.Zaposleniks.InsertOnSubmit(z);
            baza.SubmitChanges();

            Zaposlenik zap = baza.Zaposleniks.FirstOrDefault(x => x.ImePrezime.Contains(z.ImePrezime));
            Console.WriteLine("Dodani zaposlenik: ");
            Console.WriteLine($"ID zaposlenika je {zap.ID}, Ime i Prezime je {zap.ImePrezime}, Email je {zap.Email}, Telefon {zap.Telefon} i Adresa {zap.Adresa}");
        }
        
        static void PopisZaposlenika(LinqToSqlDataContext baza)
        {
            var popis = (from zaposlenik in baza.Zaposleniks
                        select zaposlenik).ToList();
            var odjeli = baza.Odjels.ToList();

            Console.WriteLine("ID   Ime i Prezime       Email                       Telefon          Adresa             Odjel");
            Console.WriteLine("==============================================================================================");

            foreach(var zap in popis)
            {
                Console.Write(zap.ID);
                int razmaci = 5 - zap.ID.ToString().Length;
                for (int i = 0; i < razmaci; i++) Console.Write(" ");

                Console.Write(zap.ImePrezime);
                razmaci = 20 - zap.ImePrezime.ToString().Length;
                for (int i = 0; i < razmaci; i++) Console.Write(" ");

                Console.Write(zap.Email);
                razmaci = 28 - zap.Email.ToString().Length;
                for (int i = 0; i < razmaci; i++) Console.Write(" ");

                Console.Write(zap.Telefon.Trim());
                razmaci = 17 - zap.Telefon.Trim().Length;
                for (int i = 0; i < razmaci; i++) Console.Write(" ");

                Console.Write(zap.Adresa);
                razmaci = 19 - zap.Adresa.ToString().Length;
                for (int i = 0; i < razmaci; i++) Console.Write(" ");


                string odjel = (from o in odjeli
                                where o.ID == zap.OdjelID
                                select o.Naziv).SingleOrDefault();

                Console.WriteLine(odjel);
            }

            Console.WriteLine("==============================================================================================");
        }

        static void AzurirajZaposlenika(LinqToSqlDataContext baza, int id_Zaposlenika)
        {
            Zaposlenik zap = baza.Zaposleniks.Where(x => x.ID == id_Zaposlenika).FirstOrDefault();

            if(zap == null)
            {
                Console.WriteLine("Zaposlenik ne postoji u bazi podataka.");
                return;
            }

            Console.WriteLine("Staro ime i prezime je " + zap.ImePrezime + ", Unesite novo: ");
            zap.ImePrezime = Console.ReadLine();

            Console.WriteLine("Stari email je " + zap.Email + ", Unesite novi: ");
            zap.Email = Console.ReadLine();

            Console.WriteLine("Stari telefon je " + zap.Telefon + ", Unesite novi: ");
            zap.Telefon = Console.ReadLine();

            Console.WriteLine("Stara adresa je " + zap.Adresa + ", Unesite novu: ");
            zap.Adresa = Console.ReadLine();

            var odjeli = baza.Odjels.ToList();
            string o = (from od in odjeli
                        where od.ID == zap.OdjelID
                        select od.Naziv).FirstOrDefault();

            string popisOdjela = "";
            foreach (var odjel in odjeli)
            {
                popisOdjela += odjel.ID + " - " + odjel.Naziv + ", ";
            }

            Console.WriteLine("Stari odjel je " + zap.OdjelID + " " + o + ", Unesite sifru novog (" + popisOdjela + "): ");
            zap.OdjelID = int.Parse(Console.ReadLine());

            baza.SubmitChanges();
        }

        static void BrisanjeZaposlenika(LinqToSqlDataContext baza, int id_Zaposlenika)
        {
            Zaposlenik zap = baza.Zaposleniks.Where(x => x.ID == id_Zaposlenika).FirstOrDefault();

            if(zap == null)
            {
                Console.WriteLine("Zaposlenik nije nadjen u bazi!");
                return;
            }

            baza.Zaposleniks.DeleteOnSubmit(zap);
            baza.SubmitChanges();
        }
    }
}
