using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serijalizacija.Library;

namespace Serijalizacija.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodeZaSerijalizaciju m = new MetodeZaSerijalizaciju();
            try
            {
                m.SerijalizirajNesto();
                m.DeserilizirajNesto();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
}
