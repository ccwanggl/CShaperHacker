﻿using System.Windows;

namespace DotNETFrameworkWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            double[] dataX = new double[] { 1, 2, 3, 4, 5 };
            double[] dataY = new double[] { 1, 4, 9, 16, 25 };

            WpfPlot1.Plot.AddScatter(dataX, dataY);
            WpfPlot1.Refresh();
		}
    }
}
