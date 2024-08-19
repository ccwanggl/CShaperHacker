using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MultiBinding
{
	public class ButtonStateConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			// 假设values数组包含两个布尔值
			bool condition1 = (bool)values[0];
			bool condition2 = (bool)values[1];

			// 根据条件返回结果
			return condition1 && condition2;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			// 通常不需要实现转换回的逻辑
			throw new NotImplementedException();
		}
	}

}
