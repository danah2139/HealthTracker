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
using WPF.ViewModels;

namespace WPF.UserControls
{
    /// <summary>
    /// Interaction logic for EnterMeals.xaml
    /// </summary>
    public partial class EnterMeals : UserControl
    {
        public EnterMealsVM EnterMealsVM { get; set; }
        public EnterMeals()//changed inside ()
        {
            InitializeComponent();
            EnterMealsVM = new EnterMealsVM();//changed inside()
            this.DataContext = EnterMealsVM;

        }

        private void Click_api_result(object sender, RoutedEventArgs e)
        {
            //i need to call that func(the api)
            // getFoodDataByName();
        }

        //private void getFoodDataByName()
        //{

        //}
    }
}
