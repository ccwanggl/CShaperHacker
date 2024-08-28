using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
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

namespace HelloBinding
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Student stu;
		public MainWindow()
		{
			InitializeComponent();

			// Create Data source
			stu = new Student();

			// Ready to bind
			Binding binding = new Binding();
			binding.Source = stu;
			binding.Path = new PropertyPath("Name");

			// NOTE 1: Use binding to connect the source and the target
			BindingOperations.SetBinding(
				this.textBoxName,               //	target
				TextBox.TextProperty,           //  target property that receive data
				binding                         //  Binding instance
				);

			// NOTE 2: Use SetBinding to connect the source and the target
			/*
			this.textBoxName.SetBinding(
				TextBox.TextProperty, 
				new Binding("Name") 
					{ 
						Source = stu = new Student() 
					});
			*/

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			stu.Name += "Name";
		}
	}

	class Student : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private string name;

		public string Name
		{
			get { return name; }
			set
			{
				name = value;
				if (PropertyChanged != null)
				{
					//PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
					PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
				}
			}
		}
	}
}
