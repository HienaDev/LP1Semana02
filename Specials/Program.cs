using System;

namespace Specials
{
    class Program
    {
        // This program prints max and min values of known types
        // Also prints positive and negative infinity and Nan
        static void Main(string[] args)
        {
            Console.WriteLine("Int:");
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine();

            Console.WriteLine("UInt:");
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);

            Console.WriteLine();
            
            Console.WriteLine("SByte:");
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);

            Console.WriteLine();

            Console.WriteLine("Byte:");
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            Console.WriteLine();

            Console.WriteLine("Short:");
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            Console.WriteLine();

            Console.WriteLine("UShort:");
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);

            Console.WriteLine();

            Console.WriteLine("Float:");
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            Console.WriteLine();

            Console.WriteLine("Decimal:");
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            Console.WriteLine();

            Console.WriteLine("Double:");
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine();

            Console.WriteLine("Long:");
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            Console.WriteLine();

            Console.WriteLine("ULong:");
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);

            Console.WriteLine();

            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NaN);

            Console.WriteLine();

            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NaN);

            Console.WriteLine();

            //OVERFLOW

            long maxInt = 2147483647;

            Console.WriteLine((int) maxInt);

            maxInt++;
              
            Console.WriteLine((int) maxInt);

            Console.WriteLine();

            double maxFloat = float.MaxValue;

            Console.WriteLine((float) maxFloat);

            maxFloat++;
              
            Console.WriteLine((float) maxFloat);

            Console.WriteLine();

            double maxFloat_infinity = float.MaxValue;

            Console.WriteLine((float) maxFloat_infinity);

            maxFloat_infinity *=2;
              
            Console.WriteLine((float) maxFloat_infinity);

            Console.WriteLine();

            //UNDERFLOW

            float f1, f2;

            f1 = f2 = 10000.0f;

            Console.WriteLine(f1 == f2 + 0.00001f);

            Console.WriteLine();

            double d1, d2;

            d1 = d2 = 1000000000.0;

            Console.WriteLine(d1 == d2 + 0.000000001);
        }
    }
}
