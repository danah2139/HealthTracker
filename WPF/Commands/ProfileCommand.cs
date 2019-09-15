using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF.ViewModels;

namespace WPF.Commands
{
    public class ProfileCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public event EventHandler ShowProfile;
        //public MainWindowVM CurrentVM { get; set; }

        //public ProfileCommand(MainWindowVM currentVM)
        //{
        //    this.CurrentVM = currentVM;
        //}

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ShowProfile?.Invoke(this, new EventArgs());
            //CurrentVM.ProfileCommand_ShowProfile();
        }
    }
}
