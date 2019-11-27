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
        //public event PropertyChangedEventHandler IdPropertyChanged;
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

        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set
        //    {
        //        name = value;
        //        if (NamePropertyChanged != null)
        //            NamePropertyChanged(this, new PropertyChangedEventArgs("Name"));
        //    }
        //}יכי5435א64564הה666666
        public MainWindowButtons MainWindowButtons { set; get; }
        public LogInCommand LogInCommand { set; get; }
        public GraphCommand GraphCommand { set; get; }
        public ProfileCommand ProfileCommand { set; get; }
        public EnterMealsCommand EnterMealsCommand { set; get; }
        public string[] Names { set; get; }//pural
        private MainModel Model { set; get; }
        MainWindow MainWindow { get; set; }
        //public UserControl ChildUserControl
        //{
        //    get { return (UserControl)GetValue(ChildUserControlProperty); }
        //    set { SetValue(ChildUserControlProperty, value); }
        //}
        //// Using a DependencyProperty as the backing store for ChildViewModel.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty ChildUserControlProperty =
        //    DependencyProperty.Register("ChildUserControl", typeof(UserControl), typeof(MainWindowVM));

        public MainWindowVM()
        {
            Model = new MainModel();
            //Name = "beer";
            //ID="888888"
            // MainWindow = new MainWindow();
            MainWindowButtons = new MainWindowButtons();
            //ChildUserControl = new LogIn();
            initLogIn();
            LogInCommand = new LogInCommand();
            GraphCommand = new GraphCommand();
            EnterMealsCommand = new EnterMealsCommand();
            ProfileCommand = new ProfileCommand();
            //GoToProfileCommand = new GoToProfileCommand(this);
            LogInCommand.ShowLogIn += LogInCommand_ShowlogIn;
            ProfileCommand.ShowProfile += ProfileCommand_ShowProfile;
            EnterMealsCommand.ShowEnterMeals += MealCommand_ShowEnterMeals;
            GraphCommand.ShowGraph += GraphCommand_ShowGraph;
            //GoToProfileCommand.ShowNewProfile += ProfileCommand_ShowNewProfile;
            //MainWindowButtons.ProfileButton.IsChecked = true;





            // MainWindow.userbutton.IsEnabled = true;
            //MainWindowButtons.profileButton.IsChecked = true;

            //NamePropertyChanged += MainWindowVM_NamePropertyChanged;
        }

        //private void MainWindowVM_NamePropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    if (this.UserControl.GetType().Equals(typeof(LogIn)))
        //    {
        //        this.UserControl = new LogIn();
        //    }

        //    if (this.UserControl.GetType().Equals(typeof(Profile)))
        //    {
        //        this.UserControl = new UserControls.Profile();
        //    }

        //    if (this.UserControl.GetType().Equals(typeof(Graph)))
        //    {
        //        this.UserControl = new UserControls.Graph();
        //    }

        //    if (this.UserControl.GetType().Equals(typeof(EnterMeals)))
        //    {
        //        this.UserControl = new UserControls.EnterMeals();
        //    }


        //    //we need to add one for user/ profile user control

        //}
        internal void LogInCommand_ShowlogIn(object sender, EventArgs e)
        {
            MainWindowButtons.Visibility = Visibility.Hidden;
            this.UserControl = new LogIn();
        }
        //internal void LogInCommand_ShowlogIn()
        //{
        //    this.UserControl = new LogIn();
        //}
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
            UserControl = new Graph(IdProperty);
            MainWindowButtons.Visibility = Visibility.Visible;
        }

        //internal void GraphCommand_ShowGraph()
        //{
        //    this.UserControl = new Graph();
        //}

        //internal void MealCommand_ShowEnterMeals()
        //{
        //    this.UserControl = new EnterMeals();
        //}
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


        //public void Operation(int i)
        //{
        //    switch (i)
        //    {
        //        case 1:
        //            ChildUserControl = new LogIn();
        //            break;
        //        case 2:
        //            ChildUserControl = new Profile();
        //            break;
        //        case 3:
        //            ChildUserControl = new EnterMeals();
        //            break;

        //        case 4:
        //            ChildUserControl = new Graph();
        //            break;
        //case 5:
        //    System.Windows.Application.Current.Shutdown();
        //    break;
        //}
        //}
    }
}



