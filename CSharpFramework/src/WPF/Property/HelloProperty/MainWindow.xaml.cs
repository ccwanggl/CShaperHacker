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
			Person person = new Person();
			person.SetBinding(Person.nameProperty, new Binding("Text") { Source = textbox1 });
			textbox2.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = person });

        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			/*
			Person person = new Person();
			person.Name = textbox1.Text;
			textbox2.Text = person.Name;
			*/
		}
	}

	public class Person : DependencyObject
	{
		public static readonly DependencyProperty nameProperty;

		static Person()
		{
			nameProperty = DependencyProperty.Register("Name", typeof(string), typeof(Person));
		}

		public string Name 
		{
			get
			{
				return (string)GetValue(nameProperty);
			}
			set {
				SetValue(nameProperty, value);
			}
		}

		public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase binding)
		{
			return BindingOperations.SetBinding(this, dp, binding);	
		}
 }
}
