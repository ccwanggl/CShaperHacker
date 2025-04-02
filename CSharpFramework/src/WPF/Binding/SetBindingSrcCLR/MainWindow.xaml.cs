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

namespace SetBindingSrcCLR
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	//NOTE: Binding 的源是数据的来源，所以，只要一个对象包含数据并能通过属性把数据暴露出来，它就能当作 Binding 的源。
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

			// NOTE:  xx
			// arg1: target
			// arg2: target property that receive data
			// arg3: Binding instance
			BindingOperations.SetBinding(this.textBoxName, TextBox.TextProperty, binding);

			// NOTE: xxxxxxxxxxxxxxxx
			/*
			this.textBoxName.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = stu = new Student() });
			*/

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			// 属性值的变化源
			stu.Name += "Name";
		}
	}

	class Student : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private string _name;

		public string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				if (PropertyChanged != null)
				{
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
				}
			}
		}
	}
}
