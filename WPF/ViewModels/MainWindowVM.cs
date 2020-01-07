using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.UserControls;
using System.Windows.Controls;
using WPF.Commands;
using WPF.Models;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;

namespace WPF.ViewModels
{
    public class MainWindowVM : DependencyObject, INotifyPropertyChanged

    {

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangedEventHandler NamePropertyChanged;
        private UserControl userControl;
        public UserControl UserControl
        {
            get { return userControl; }
            set
            {
                if (userControl == value)
                    return;
                userControl = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("UserControl"));
                }

            }
        }

        public static readonly DependencyProperty Id = DependencyProperty.Register("IdProperty", typeof(String), typeof(MainWindowVM));
        public String IdProperty
        {
            get { return (String)GetValue(Id); }
            set { SetValue(Id, value); }
        }

        public MainWindowButtons MainWindowButtons { set; get; }
        public LogInCommand LogInCommand { set; get; }
        public GraphCommand GraphCommand { set; get; }
        public ProfileCommand ProfileCommand { set; get; }
        public EnterMealsCommand EnterMealsCommand { set; get; }
        public string[] Names { set; get; }//pural
        private MainModel Model { set; get; }
        MainWindow MainWindow { get; set; }

        public MainWindowVM()
        {
            Model = new MainModel();
            MainWindowButtons = new MainWindowButtons();
            initLogIn();
            LogInCommand = new LogInCommand();
            GraphCommand = new GraphCommand();
            EnterMealsCommand = new EnterMealsCommand();
            ProfileCommand = new ProfileCommand();
            LogInCommand.ShowLogIn += LogInCommand_ShowlogIn;
            ProfileCommand.ShowProfile += ProfileCommand_ShowProfile;
            EnterMealsCommand.ShowEnterMeals += MealCommand_ShowEnterMeals;
            GraphCommand.ShowGraph += GraphCommand_ShowGraph;

        }

   
        internal void LogInCommand_ShowlogIn(object sender, EventArgs e)
        {
            MainWindowButtons.Visibility = Visibility.Hidden;
            this.UserControl = new LogIn();
            (UserControl as LogIn).LogInVM.PropertyChanged += isLogedInFunc;

        }

        internal void GraphCommand_ShowGraph(object sender, EventArgs e)
        {
            this.UserControl = new Graph(IdProperty);
        }
        private void initLogIn()
        {
            MainWindowButtons.Visibility = Visibility.Hidden;
            UserControl = new LogIn();
          
            (UserControl as LogIn).LogInVM.PropertyChanged += isLogedInFunc;
           
        }
        //when user loged in successfully
        private void isLogedInFunc(object sender, PropertyChangedEventArgs e)
        {
            IdProperty = (sender as LogInVM).Id;
            UserControl = new ProfileDetails(IdProperty);
            MainWindowButtons.Visibility = Visibility.Visible;
        }

        internal void MealCommand_ShowEnterMeals(object sender, EventArgs e)
        {
            this.UserControl = new EnterMeals();
        }

        private void UserControls_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
        }

    
        internal void ProfileCommand_ShowProfile(object sender, EventArgs e)
        {
            this.UserControl = new ProfileDetails(IdProperty);
        }


        
    }
}



