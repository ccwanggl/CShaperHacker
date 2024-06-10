using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PACS
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

		private void BtnRotate_Click(object sender, RoutedEventArgs e)
		{
			//设置关联按钮
			BtnRotate.ContextMenu.PlacementTarget = BtnRotate;
			//弹出时的位置在底部
			BtnRotate.ContextMenu.Placement = PlacementMode.Bottom;
			//显示菜单
			BtnRotate.ContextMenu.IsOpen = true;
		}

		private void MyRotate_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("rotate");
		}

		private void RotateClear_Click(object sender, RoutedEventArgs e)
		{

		}

		private void RotateRight90_Click(object sender, RoutedEventArgs e)
		{

		}

		private void RotateLeft90_Click(object sender, RoutedEventArgs e)
		{

		}

		private void RotateHor_Click(object sender, RoutedEventArgs e)
		{

		}

		private void RotateVer_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
