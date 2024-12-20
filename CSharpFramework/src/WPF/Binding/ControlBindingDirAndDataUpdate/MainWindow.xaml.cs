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

namespace ControlBindingDirAndDataUpdate
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			var binding = new Binding
			{
				Source = Slider2,
				// NOTE The type of the binding Path is PropertyPath, not string.
				Path = new PropertyPath("Value"),
				UpdateSourceTrigger = UpdateSourceTrigger.LostFocus,
				Mode = BindingMode.TwoWay
			};

			//BindingOperations.SetBinding(this.textBox2, TextBox.TextProperty, binding);
			TextBox2.SetBinding(TextBox.TextProperty, binding);

		}
	}
}
