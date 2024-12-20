using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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

namespace SetSourceToItemsControl
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			List<Student> stuList = new List<Student>()
			{
				new Student(){Id=0, Name = "Tim", Age=29},
				new Student(){Id=1, Name = "Tom", Age=28},
				new Student(){Id=2, Name = "Kyle", Age=27},
				new Student(){Id=3, Name = "Tony", Age=26},
				new Student(){Id=4, Name = "Vina", Age=25},
				new Student(){Id=5, Name = "Mike", Age=24},
			};

			this.ListBoxStudents1.ItemsSource = stuList;
			this.ListBoxStudents1.DisplayMemberPath = "Name";
			var binding1 = new Binding("SelectedItem.Id") { Source = this.ListBoxStudents1 };
			this.TextBoxId1.SetBinding(TextBox.TextProperty, binding1);

			this.ListBoxStudents2.ItemsSource = stuList;
			var binding2 = new Binding("SelectedItem.Name") { Source = this.ListBoxStudents2 };
			this.TextBoxId2.SetBinding(TextBox.TextProperty, binding2);
		}
	}

	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
	}
}
