using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTypeConverter
{
	public class StringToHumanTypeConverter : System.ComponentModel.TypeConverter
	{
		public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
		{
			if (value is string)
			{
				Human h = new Human();
				h.Name = (string)value;
				return h;
			}

			return base.ConvertFrom(context, culture, value);
		}
	}
}
