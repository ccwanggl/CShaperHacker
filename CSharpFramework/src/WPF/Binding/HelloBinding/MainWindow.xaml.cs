using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace HelloBinding
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly Student _stu;
		public MainWindow()
		{
			InitializeComponent();

			// Create Data source
			_stu = new Student();

			// Ready to bind
			//! "Path" 指定要绑定的属性
			var binding = new Binding
			{
				Source = _stu,
				Path = new PropertyPath("Name"),
				Mode = BindingMode.TwoWay
			};

			// NOTE 1: Use binding to connect the source and the target
			BindingOperations.SetBinding(
				this.textBoxName,						//	target
				TextBox.TextProperty,				//  target property that receive data
				binding									//  Binding instance
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
			_stu.Name += "event  ";
		}
	}

	internal class Student : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private string _name;

		public string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
			}
		}
	}
}
