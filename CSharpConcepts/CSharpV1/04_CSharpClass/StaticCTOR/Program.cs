using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCTOR
{
    internal class Program
    {

		class RandomNumberClass
		{
			private static Random RandomKey;

			static RandomNumberClass()
			{
				RandomKey = new Random();
			}

			public int GetRandomNumber()
			{
				return RandomKey.Next();
			}
		}

        static void Main(string[] args)
        {
			RandomNumberClass a = new RandomNumberClass();
			RandomNumberClass b = new RandomNumberClass();

			Console.WriteLine("Next Random #: {0}", a.GetRandomNumber());
			Console.WriteLine($"Next Random #:  {b.GetRandomNumber()}");
		}
    }
}
