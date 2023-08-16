using System;

namespace Nullable
{
    internal class Program
    {
        private static void Main()
        {
            int? x = null;

            var y = x ?? 100;
            Console.WriteLine(y.GetType().FullName);
        }
    }
}
