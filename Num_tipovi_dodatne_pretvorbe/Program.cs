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

            int i = Int32.MinValue;
            int j = Int32.MaxValue;
            uint k = 4294967295;

            int hex = 0x2F;
            int bin = 0b_0010_1111;
            Console.WriteLine(hex);
            Console.WriteLine(bin);

            long long1 = long.MinValue;
            long long2 = long.MaxValue;

            ulong ulong1 = ulong.MaxValue;

            Console.WriteLine();
            Console.WriteLine("Decimalni tipovi: ");
            Console.WriteLine("=======================");

            float float1 = 123456.5F;
            float float2 = 1.123456f;
            Console.WriteLine(float1);
            Console.WriteLine(float2);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            double double1 = 1234455676346.5;
            double double2 = 1.23432454366347d;
            Console.WriteLine(double1);
            Console.WriteLine(double2);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            decimal decimal1 = decimal.MinValue;
            decimal decimal2 = decimal.MaxValue;
            Console.WriteLine(decimal1);
            Console.WriteLine(decimal2);

            string num = decimal2.ToString();
            Console.WriteLine(num.Length); 

        }
    }
}
