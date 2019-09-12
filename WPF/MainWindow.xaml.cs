using System;
using WPF.Commands;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
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
using System.Windows.Forms;
using WPF.UserControls;
using BE;
using WPF.ViewModels;


namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowVM CurrentVM { get; set; }
       // public ProfileCommand ProfileCommand { get; set; }

        public MainWindow()
        {
          InitializeComponent();
  //          ToolTipService.ShowDurationProperty.OverrideMetadata(
//               typeof(DependencyObject), new FrameworkPropertyMetadata(Int32.MaxValue));
 //           App.Current.Dispatcher.Invoke(new Action(() => Run()));
            CurrentVM = new MainWindowVM();
         //   ProfileCommand = new ProfileCommand();
            this.DataContext = CurrentVM;
           
            
        }
     
    }
}

   
    

