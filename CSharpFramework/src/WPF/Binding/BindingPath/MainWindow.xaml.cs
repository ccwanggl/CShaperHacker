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

namespace BindingPath
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		public MainWindow()
		{
			InitializeComponent();

			// NOTE: Bind Binding to the source property
			Binding binding = new Binding();
			binding.Path = new PropertyPath("Value");
			binding.Source = this.slider2;
			binding.Mode = BindingMode.TwoWay;
			binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;

			this.textBox2.SetBinding(TextBox.TextProperty, binding);

			// NOTE: Use the Binding ctor
			Binding binding2 = new Binding("Value") { Source = this.slider3 };
			this.textBox3.SetBinding(TextBox.TextProperty, binding2);




			City city = new City();
			city.Name = "长春";

			List<City> cities = new List<City> { city };
			Province province = new Province() { Name = "吉林", CityList = cities };

			List<Province> provinces = new List<Province> { province };
			Country country = new Country() { Name = "中国", ProvinceList = provinces };

			List<Country> countryList = new List<Country> { country };

			this.textBox11.SetBinding(TextBox.TextProperty, new Binding("/Name") { Source = countryList });
			this.textBox22.SetBinding(TextBox.TextProperty, new Binding("/ProvinceList/Name") { Source = countryList });
			this.textBox33.SetBinding(TextBox.TextProperty, new Binding("/ProvinceList/CityList/Name") { Source = countryList });


			List<string> stringList = new List<string>() { "Tim", "Tom", "Blog" };
			textBox111.SetBinding(TextBox.TextProperty, new Binding("/") { Source = stringList });
			textBox222.SetBinding(TextBox.TextProperty, new Binding("/Length") { Source = stringList, Mode = BindingMode.OneWay });
			textBox333.SetBinding(TextBox.TextProperty, new Binding("/[1]") { Source = stringList, Mode = BindingMode.OneWay });
		}
	}
}
