using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedTypeDelegate
{
	delegate int NumberChanger(int n);

	internal class Program
	{
		static int num = 10;
		public static int AddNum(int p)
		{
			num += p;
			return num;
		}

		public static int MultNum(int p)
		{
			num *= p;
			return num;
		}

		public static int getNum()
		{
			return num;
		}

        static void Main(string[] args)
        {

			NumberChanger nc1  = new NumberChanger(AddNum);
			nc1(25);
			Console.WriteLine(getNum());
		}
    }
}
