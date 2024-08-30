using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ControlAsBindingSrc
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			this.textBox2.SetBinding(TextBox.TextProperty, new Binding("Value") { ElementName = "slider2" });
		}
	}
}
