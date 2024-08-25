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

namespace HelloProperty
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Person person = new Person();
			person.Name = textbox1.Text;        // SetValue
			textbox2.Text = person.Name;        // GetValue
		}
	}

	// ! DependencyProperty must be used in the DependencyObject
	public class Person : DependencyObject
	{
		// ! use public static readonly to 
		public static readonly DependencyProperty nameProperty;

		static Person()
		{
			//! not use "new", use "Register" to create property
			nameProperty = DependencyProperty.Register(
				"Name",                     // which CLR property as wrapper
				typeof(string),             // what type that DependencyProperty will store
				typeof(Person));            // what the DependencyProperty belong to
		}

		public string Name
		{
			get
			{
				return (string)GetValue(nameProperty);
			}
			set
			{
				SetValue(nameProperty, value);
			}
		}

		public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase binding)
		{
			return BindingOperations.SetBinding(this, dp, binding);
		}
	}
}
