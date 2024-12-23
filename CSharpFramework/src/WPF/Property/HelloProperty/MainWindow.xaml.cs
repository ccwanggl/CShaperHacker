using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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
			
			var person = new Person();
			person.SetBinding(Person.NameProperty, new Binding("Text") { Source = Textbox1 });
			Textbox2.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = person });
		}
	}

	//! DependencyProperty must be used in the DependencyObject
	public class Person : DependencyObject
	{
		//! use public static readonly to 
		public static readonly DependencyProperty NameProperty;

		static Person()
		{
			//! not use "new", use "Register" to create property
			NameProperty = DependencyProperty.Register(
				"Name",                    // which CLR property as wrapper
				typeof(string),					// what type the DependencyProperty will store
				typeof(Person));				// what type the DependencyProperty related to
		}

		public string Name
		{
			get
			{
				return (string)GetValue(NameProperty);
			}
			set
			{
				SetValue(NameProperty, value);
			}
		}

		public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase binding)
		{
			return BindingOperations.SetBinding(this, dp, binding);
		}
	}
}
