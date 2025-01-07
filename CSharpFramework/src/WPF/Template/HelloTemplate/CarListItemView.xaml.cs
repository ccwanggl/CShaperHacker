using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloTemplate
{
	/// <summary>
	/// Interaction logic for CarListItemView.xaml
	/// </summary>
	public partial class CarListItemView : UserControl
	{
		public CarListItemView()
		{
			InitializeComponent();
		}

		private Car _car;
		public Car Car
		{
			get { return _car; }
			set
			{
				_car = value;
				this.textBlockName.Text = _car.Name;
				this.textBlockYear.Text = _car.Year;
				string uriStr = string.Format(@"/Resources/Logos/{0}.jpg", _car.Automaker);
				this.imageLogo.Source = new BitmapImage(new Uri(uriStr, UriKind.Relative));
			}
		}
	}
}
