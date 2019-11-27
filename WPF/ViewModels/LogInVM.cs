using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF.Commands;
using WPF.Models;
using WPF.UserControls;
using BE;

namespace WPF.ViewModels
{
    public class LogInVM: DependencyObject, INotifyPropertyChanged
    {
        public LogIn LogIn { get; set; }
        public LogInModel LogInModel { get; set; }
        public GoToProfileCommand GoToProfileCommand { get; set; }
        public ICommand CheckLogInCommand { get; set; }
        public MainWindowVM MainWindowVM { get; set; }
        public ProfileCommand ProfileCommand { get; set; }
        // public ObservableCollection<User> Users { get; set; }
        public LogInVM()
        {
            LogInModel = new LogInModel();
            CheckLogInCommand = new CheckLogInCommand(this);
            GoToProfileCommand = new GoToProfileCommand();
     //       ProfileCommand = new ProfileCommand();
            //Users = new ObservableCollection<User>();

        }
        public string id;
        public string Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        //true- the popup of register will be opened when click on register
        public static readonly DependencyProperty RegisterPopUpIsOpen = DependencyProperty.Register("RegisterPopUpIsOpenProperty", typeof(Boolean), typeof(LogInVM), new PropertyMetadata(false));
        public Boolean RegisterPopUpIsOpenProperty
        {
            get { return (Boolean)GetValue(RegisterPopUpIsOpen); }
            set { SetValue(RegisterPopUpIsOpen, value); }
        }

        public static readonly DependencyProperty IsRegistrationDone = DependencyProperty.Register("IsRegistrationDoneProperty", typeof(Boolean), typeof(LogInVM), new PropertyMetadata(new PropertyChangedCallback(onRegisterationDonePropertyChanged)));
        public Boolean IsRegistrationDoneProperty
        {
            get { return (Boolean)GetValue(IsRegistrationDone); }
            set { SetValue(IsRegistrationDone, value); }
        }

        
        private static void onRegisterationDonePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue == true)
            {
                (d as LogInVM).RegisterPopUpIsOpenProperty = false;
                (d as LogInVM).IsRegistrationDoneProperty = false;
            }
        }
        Boolean isConnected;
        public Boolean IsConnectedProperty
        {
            get { return isConnected; }
            set { isConnected = value; if (value == true) NotifyPropertyChanged("connected"); }
        }
        public void CheckLogInNow()
        {
            User user = LogInModel.GetUserInfo();
            if (user != null)
            {
                IsConnectedProperty = true;
                Id = user.UserId;
                id = user.UserId;

            }
        }

        public void GoTOProfile()
        {
            RegisterPopUpIsOpenProperty = true;
        }
    }
}
