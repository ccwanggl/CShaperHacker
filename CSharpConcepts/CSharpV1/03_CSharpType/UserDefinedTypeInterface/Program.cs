using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedTypeInterface
{
	interface ISampleInterface
	{
		void SampleMethod();
	}

	class ImplementationClass : ISampleInterface
	{
		void ISampleInterface.SampleMethod()
		{
			Console.WriteLine("Explicit interface member implementation");
		}
	}

    internal class Program
    {
        static void Main(string[] args)
        {
			ISampleInterface sample = new ImplementationClass();
			sample.SampleMethod();
        }
    }
}
