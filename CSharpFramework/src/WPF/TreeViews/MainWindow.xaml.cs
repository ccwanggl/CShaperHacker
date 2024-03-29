﻿using System;
using System.IO;
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

namespace TreeViews
{

	

	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
    {
	#region Constructor
        public MainWindow()
        {
            InitializeComponent();
        }
		#endregion

		#region On Loaded

		/// <summary>
		/// when  the application first opens
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <exception cref="NotImplementedException"></exception>
		
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			foreach (var derive in Directory.GetLogicalDrives() )
			{
				var item = new TreeView();
				FolderView.Items.Add( item );
			}
		}

		#endregion
    }
}
