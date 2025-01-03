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

namespace CommandParameter
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

		private void New_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(this.nameTextBox.Text))
			{
				e.CanExecute = true;
			}
			else
			{
				e.CanExecute = false;
			}
		}

		private void New_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			string name = this.nameTextBox.Text;
			if (e.Parameter.ToString() == "Teacher")
			{
				this.listBoxNewItems.Items.Add(string.Format("New Teacher: {0}, 学而不厌，诲人不倦.", name));
			}
			else if (e.Parameter.ToString() == "Student")
			{
				this.listBoxNewItems.Items.Add(string.Format("New Student: {0}, 好好学习，天天向上.", name));
			}
		}
	}
}
