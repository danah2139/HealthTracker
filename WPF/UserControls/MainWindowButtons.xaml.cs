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
using WPF.Commands;
using WPF.ViewModels;

namespace WPF.UserControls
{
    /// <summary>
    /// Interaction logic for MainWindowButtons.xaml
    /// </summary>
    public partial class MainWindowButtons : UserControl
    {
        public LogInCommand LogInCommand { get; set; }
        public GraphCommand GraphCommand { get; set; }
        public ProfileCommand ProfileCommand { get; set; }
        public EnterMealsCommand EnterMealsCommand { get; set; }

        public MainWindowButtons()
        {
            InitializeComponent();
            LogInCommand = new LogInCommand();
            GraphCommand = new GraphCommand();
            ProfileCommand = new ProfileCommand();
            EnterMealsCommand = new EnterMealsCommand();
            //MainGrid.DataContext = new MainWindowVM();



        }
    }
}
