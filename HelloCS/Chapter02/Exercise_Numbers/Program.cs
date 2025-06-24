using System.Runtime.InteropServices;

namespace Exercise_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "Type", "Byte(s) of memory", "Min", "Max");

            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "short", sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "int", sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "long", sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
/*
            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "Int128", Marshal.SizeOf<Int128>(), Int128.MinValue, Int128.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "UInt128", Marshal.SizeOf<UInt128>(), UInt128.MinValue, UInt128.MaxValue);

            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "Half", Marshal.SizeOf<Half>(), Half.MinValue, Half.MaxValue);*/
            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "float", sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "double", sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        }
    }
}
