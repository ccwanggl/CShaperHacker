using System;

namespace GerenicExample5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3 ,4,5};
            int[] a2 = { 1, 2, 3, 4,5,6 };

            double[] a3 = { 1, 2, 3, 4, 5, };
            double[] a4 = { 1, 2, 3, 4, 5, };

            var result = Zip(a1, a2);
            Console.WriteLine(string.Join(",", result));
        }

        static T[] Zip<T>(T[] a, T[] b)
        {
            T[] zipped = new T[a.Length + b.Length];
            int ai = 0;
            int bi = 0; 
            int zi = 0;

            do
            {
                if (ai < a.Length) zipped[zi++] = a[ai++];
                if (bi < b.Length) zipped[zi++] = b[bi++];
            }
            while (ai < a.Length || bi < b.Length);

            return zipped;
        }
    }
}
