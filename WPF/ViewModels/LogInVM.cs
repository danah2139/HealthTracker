using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.Commands;
using WPF.Models;
using WPF.UserControls;


namespace WPF.ViewModels
{
    public class LogInVM
    {
        public LogIn LogIn { get; set; }
        public LogInModel LogInModel { get; set; }
        public GoToProfileCommand GoToProfileCommand { get; set; }
        public ICommand CheckLogInCommand { get; set; }

        // public ObservableCollection<User> Users { get; set; }
        public LogInVM()
        {
            LogInModel = new LogInModel();
            CheckLogInCommand = new CheckLogInCommand(this);
            GoToProfileCommand = new GoToProfileCommand();
            //ProfileCommand = new ProfileCommand(this);
            //Users = new ObservableCollection<User>();

        }

        internal void CheckLogInNow()
        {
            LogInModel.GetUserInfo();
        }

        //internal void GoTOProfile()
        //{


        //}
    }
}
