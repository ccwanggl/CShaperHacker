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

namespace RelativeSource
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

			System.Windows.Data.RelativeSource rs = new System.Windows.Data.RelativeSource();
			rs.AncestorLevel = 2;
			rs.AncestorType = typeof(DockPanel);
			Binding binding = new Binding("Name") { RelativeSource = rs };
			this.textBox11.SetBinding(TextBox.TextProperty, binding);

			System.Windows.Data.RelativeSource rs1 = new System.Windows.Data.RelativeSource();
			rs1.Mode = RelativeSourceMode.Self;
			Binding binding1 = new Binding("Name") { RelativeSource = rs1 };
			this.textBox111.SetBinding(TextBox.TextProperty, binding1);
		}
    }
}
