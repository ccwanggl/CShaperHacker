using System;

namespace Nullable
{
    internal class Program
    {
        private static void Main()
        {
            // NOTE: 没交作业 Since C#3.0
            // NOTE: Old school
            Nullable<int> xx = null;
            Console.WriteLine(xx.HasValue);

            int? x = null;
            var y = x ?? 1;
            Console.WriteLine(y.GetType().FullName);
        }
    }
}
