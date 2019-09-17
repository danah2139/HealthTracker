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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    /// 
    public partial class LogIn : UserControl
    {
        public LogInVM LogInVM { get; set; }
        //public ProfileCommand ProfileCommand { get; set; }
        //MainWindowVM MainWindowVM { get; set; }


        public LogIn()
        {
            InitializeComponent();
            LogInVM = new LogInVM();
            //ProfileCommand = new ProfileCommand();
            this.DataContext = LogInVM;

        }
    }
}
