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

namespace HelloCommand
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			InitializeCommand();
		}

		private RoutedCommand clearCmd = new RoutedCommand("Clear", typeof(MainWindow));

		private void InitializeCommand()
		{
			this.cmd.Command = this.clearCmd;
			this.clearCmd.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));

			this.cmd.CommandTarget = this.textBoxA;

			CommandBinding cb = new CommandBinding();
			cb.Command = this.clearCmd;
			cb.CanExecute += new CanExecuteRoutedEventHandler(cb_CanExecute);
			cb.Executed += new ExecutedRoutedEventHandler(cb_Executed);

			this.stackPanel.CommandBindings.Add(cb);
		}

		void cb_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(this.textBoxA.Text))
			{
				e.CanExecute = false;
			}
			else
			{
				e.CanExecute = true;
			}

			e.Handled = true;
		}

		void cb_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			this.textBoxA.Clear();
			e.Handled |= true;
		}
	}
}
