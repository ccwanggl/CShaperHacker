using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProperty
{
	class Trivial
	{
		public static int MyValue {  get; set; }	
		public void PrintValue()
		{
			Console.WriteLine("Value from inside: {0}", MyValue);
		}
	}
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Init Value: {0}", Trivial.MyValue);
			Trivial.MyValue = 10;
			Console.WriteLine("New Value: {0}", Trivial.MyValue);
		}
    }
}
