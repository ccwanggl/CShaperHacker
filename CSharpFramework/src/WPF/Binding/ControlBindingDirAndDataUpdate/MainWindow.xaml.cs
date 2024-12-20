using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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

			if (binding.NotifyOnSourceUpdated)
			{
				
			}

			if (binding.NotifyOnTargetUpdated)
			{
				
			}

			//BindingOperations.SetBinding(this.textBox2, TextBox.TextProperty, binding);
			TextBox2.SetBinding(TextBox.TextProperty, binding);

		}
	}
}
