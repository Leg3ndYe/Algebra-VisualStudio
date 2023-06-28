using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullabilni_tipovi_s_uvjetima
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int? i = null;
            int j = -200;

            Console.WriteLine("=============================");
            Console.WriteLine("Nullabilni tipovi s uvjetima");
            Console.WriteLine("=============================");

            if (i < j) Console.WriteLine("I je manji od J");
            else if (i > j) Console.WriteLine("I je veci od J");
            else if (i == j) Console.WriteLine("I je jednak J");
            else Console.WriteLine("Ne mozemo napraviti usporedbu!");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine("Nullabilni tipovi s uvjetima i pomocnim klasama");
            Console.WriteLine("================================================");

            if (Nullable.Compare<int>(i, j) < 0) Console.WriteLine("I je manji od J");

            else if (Nullable.Compare<int>(i, j) > 0) Console.WriteLine("I je veci od J");

            else Console.WriteLine("I je jednak J");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine("Nullabilni tipovi s uvjetima i pomocnim klasama");
            Console.WriteLine("================================================");

            if (i == null) Console.WriteLine("I je null");
            
            else Console.WriteLine(i);

            ArrayList ar = null;
            if(ar== null) ar = new ArrayList();
            ar.Add(4);
        }
    }
}
