using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_tipovi_dodatne_pretvorbe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer tipovi: ");
            Console.WriteLine("===========================");

            byte byte1 = 255;
            //byte byte2 = -128;
            sbyte sbyte1 = -128;
            sbyte sbyte2 = 127;

            short short1 = -32768;
            short short2 = -32767;
            //short short3 = 35000;

            ushort ushort1 = 65535;
            //ushort ushort2 = -32000;

            Console.WriteLine(Int16.MaxValue);
            Console.WriteLine(Int16.MinValue);
            Console.WriteLine(UInt16.MaxValue);
            Console.WriteLine(UInt16.MinValue);

            Console.WriteLine(Int32.MaxValue);
        }
    }
}
