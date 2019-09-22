using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.UserControls;
using WPF.ViewModels;
using System.Windows.Controls;
using System.ComponentModel;

namespace WPF.Commands
{
    public class GoToProfileCommand : ICommand
    {
        private LogInVM logInVM;

        public event EventHandler ShowNewProfile;
        //public event PropertyChangedEventHandler PropertyChanged;
        //private UserControl userControl;
        //public UserControl UserControl
        //{
        //    get { return userControl; }
        //    set
        //    {
        //        if (userControl == value)
        //            return;
        //        userControl = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("UserControl"));
        //        }
        //        //userControl = value;
        //    }
        //}
        public LogInVM LogInVM { get; set; }
        public Profile Profile { get; set; }
        public MainWindowVM MainWindowVM { get; set; }
        //public GoToProfileCommand(MainWindowVM mainWindowVM)
        //{
        //    this.MainWindowVM = mainWindowVM;

        //}

        public GoToProfileCommand(LogInVM logInVM)
        {
            this.logInVM = logInVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //MainWindowVM = new MainWindowVM();
            //MainWindowVM.UserControl = new Profile(); 
            //ShowNewProfile?.Invoke(this, new EventArgs());
            //MainWindowVM = new MainWindowVM();
            //MainWindowVM.UserControl = new Profile();
            this.logInVM.GoTOProfile();
        }
    }
}
