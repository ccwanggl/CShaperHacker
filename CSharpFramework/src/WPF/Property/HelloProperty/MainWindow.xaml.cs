using System.Windows;
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
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Person person = new Person
			{
				Name = Textbox1.Text			// SetValue
			};
			Textbox2.Text = person.Name;        // GetValue
		}
	}

	// ! DependencyProperty must be used in the DependencyObject
	public class Person : DependencyObject
	{
		// ! use public static readonly to 
		public static readonly DependencyProperty NameProperty;

		static Person()
		{
			//! not use "new", use "Register" to create property
			NameProperty = DependencyProperty.Register(
				"Name",                     // which CLR property as wrapper
				typeof(string),             // what type that DependencyProperty will store
				typeof(Person));            // what the DependencyProperty belong to
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
