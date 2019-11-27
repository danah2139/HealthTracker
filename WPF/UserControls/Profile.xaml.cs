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
using BE;
using System.ComponentModel;

namespace WPF.UserControls
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : UserControl
    {
        public ProfileVM ProfileVM;
        public Profile()
        {
            InitializeComponent();
            ProfileVM = new ProfileVM();
            ProfileVM.PropertyChanged += viewModelPropertyChanged;
            this.DataContext = ProfileVM;
           
        }

        public static readonly DependencyProperty IsDone = DependencyProperty.Register("IsDoneProperty", typeof(Boolean), typeof(Profile));
        public Boolean IsDoneProperty
        {
            get { return (Boolean)GetValue(IsDone); }
            set { SetValue(IsDone, value); }
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void viewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsDone")
                IsDoneProperty = true;
        }



        //private void Add_Click(object sender, RoutedEventArgs e)
        //{
        //    ProfileVM.Users.Add(new User { Name = this.nameTextBox.Text,
        //        ID = Int32.Parse(this.idTextBox.Text), GoalWeight = Int32.Parse(this.goalWeightTextBox.Text),
        //        Height = Int32.Parse(this.heightTextBox.Text),
        //        Weight = Convert.ToDouble(this.weightTextBox.Text),
        //        DateOfWeight = this.dateOfWeightTextBox.Text,
        //        DateOfBirth = Convert.ToDateTime(this.birthDayDatePicker.Text),
        //        Gender = Enum.(this.genderPersonComboBox.SelectedItem);
        //    });
        //}
    }
}
