using System;
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
        

        public Graph()
        {
            InitializeComponent();
            GraphVM = new GraphVM();
            this.DataContext = GraphVM;
            //showColumnChart();
            //LoadLineChartData();
        }

 //       private void showColumnChart()
 //       {
 //           List<KeyValuePair<string, int>> valueList = new List<KeyValuePair<string, int>>();
 //           valueList.Add(new KeyValuePair<string, int>("Today", 10));
 //           valueList.Add(new KeyValuePair<string, int>("Misc", 20));
 //           valueList.Add(new KeyValuePair<string, int>("Tester", 50));
 //           valueList.Add(new KeyValuePair<string, int>("QA", 30));
 //           valueList.Add(new KeyValuePair<string, int>("Project Manager", 40));


 ////           lineChart.ToolTip = true;
 //           //Setting data for line chart
 //           lineChart.DataContext = valueList;
            
 //        }
        //private void LoadLineChartData()
        //{
        //    ((LineSeries)myChart.Series[0]).ItemsSource =
        //        new KeyValuePair<DateTime, int>[]{
        //        new KeyValuePair<DateTime,int>(DateTime.Now, 100),
        //        new KeyValuePair<DateTime,int>(DateTime.Now.AddMonths(1), 130),
        //        new KeyValuePair<DateTime,int>(DateTime.Now.AddMonths(2), 150),
        //        new KeyValuePair<DateTime,int>(DateTime.Now.AddMonths(3), 125),
        //        new KeyValuePair<DateTime,int>(DateTime.Now.AddMonths(4),155) };
        //}

        
    }
}
