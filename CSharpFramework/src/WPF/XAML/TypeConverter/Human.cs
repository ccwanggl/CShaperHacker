using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTypeConverter
{
	[TypeConverter(typeof(StringToHumanTypeConverter))]
	public class Human
	{
		public string Name { get; set; }
		public Human Child { get; set; }
	}
}
