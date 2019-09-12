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

namespace WPF.ViewModels
{
    public class MainWindowVM : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangedEventHandler NamePropertyChanged;
        public event PropertyChangedEventHandler IdPropertyChanged;
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
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                if (IdPropertyChanged != null)
                    IdPropertyChanged(this, new PropertyChangedEventArgs("Id"));
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                if (NamePropertyChanged != null)
                    NamePropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }
        public MainWindowButtons MainWindowButtons { set; get; }
        public EnterMealsCommand MealCommand { set; get; }
        public GraphCommand GraphCommand { set; get; }
        public ProfileCommand ProfileCommand { set; get; }
        public string[] Names { set; get; }//pural
        private MainModel Model { set; get; }
        //MainWindow MainWindow { get; set; }

        public MainWindowVM()
        {
            Model = new MainModel();
            Name = "beer";
            //ID="888888"
           // MainWindow = new MainWindow();
            MainWindowButtons = new MainWindowButtons();
            MealCommand = new EnterMealsCommand();
            GraphCommand = new GraphCommand();
            ProfileCommand = new ProfileCommand();
            //Cities = Model.getListOfCities();
            MealCommand.ShowEnterMeals += MealCommand_ShowEnterMeals;
            ProfileCommand.ShowProfile += ProfileCommand_ShowProfile;

            GraphCommand.ShowGraph += GraphCommand_ShowGraph;
            
            UserControl = new EnterMeals("beer");

            // MainWindow.userbutton.IsEnabled = true;
            MainWindowButtons.profileButton.IsChecked = true;

            NamePropertyChanged += MainWindowVM_NamePropertyChanged;
        }

        private void MainWindowVM_NamePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (this.UserControl.GetType().Equals(typeof(EnterMeals)))
                this.UserControl = new EnterMeals(name);


            //we need to add one for user/ profile user control

        }

        private void GraphCommand_ShowGraph(object sender, EventArgs e)
        {
            this.UserControl = new Graph();
        }

        private void MealCommand_ShowEnterMeals(object sender, EventArgs e)
        {
            this.UserControl = new EnterMeals(Name);
        }

        private void UserControls_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
        }

        private void ProfileCommand_ShowProfile(object sender, EventArgs e)
        {
            this.UserControl = new Profile(Id);
        }
    }
}

