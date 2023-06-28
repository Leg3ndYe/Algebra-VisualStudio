using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_s_uvjetom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] polje = new int[10];
            int index = 20;
            try
            {
                polje[index] = 2;
            }
            catch(Exception ex) when (LogirajIznimku(ex))
            {
                Console.WriteLine(ex.Message + " index manji od 10.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static bool LogirajIznimku(Exception ex)
        {
            Console.WriteLine("Logirao sam iznimku! \n" + ex.Message);
            return false;
        }
    }
}
