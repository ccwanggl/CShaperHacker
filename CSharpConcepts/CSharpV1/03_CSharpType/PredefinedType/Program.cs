using System;

namespace PredefinedType
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Limit of the sbyte type: {0} ~ {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("Limit of the type type: {0} ~ {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Limit of the short type: {0} ~ {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Limit of the ushort type: {0} ~ {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("Limit of the int type: {0} ~ {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Limit of the uint type: {0} ~ {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("Limit of the long type: {0} ~ {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("Limit of the ulong type: {0} ~ {1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("Limit of the char type: {0} ~ {1}", char.MinValue, char.MaxValue);
            Console.WriteLine("Limit of the float type: {0} ~ {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Limit of the double type: {0} ~ {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("Limit of the decimal type: {0} ~ {1}", decimal.MinValue, decimal.MaxValue);

            const bool b = false;
            Console.WriteLine("Limit of the bool type: {0}", b);
        }
    }
}
