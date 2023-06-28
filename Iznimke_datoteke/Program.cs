using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_datoteke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime_datoteke = "primjer.txt";
            try
            {
                if (File.Exists(ime_datoteke)) File.Delete(ime_datoteke);
                Console.WriteLine("Stvaranje datoteke na disku: ");
                using (FileStream fs = File.Create(ime_datoteke))
                {
                    Console.WriteLine("Datoteka stvorena s imenom " + ime_datoteke);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
