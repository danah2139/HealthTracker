﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.ViewModels;



namespace WPF.UserControls
{
    /// <summary>
    /// Interaction logic for Graph.xaml
    /// </summary>
    public partial class Graph : UserControl
    {
        public GraphVM GraphVM { get; set; }
        

        public Graph(string id)
        {
            InitializeComponent();
            GraphVM = new GraphVM(id);
            this.DataContext = GraphVM;
            //showColumnChart();
            //LoadLineChartData();
        }

 
        
    }
}
