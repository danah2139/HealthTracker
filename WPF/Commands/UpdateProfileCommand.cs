using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.ViewModels;

namespace WPF.Commands
{
    public class UpdateProfileCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public ProfileVM CurrentVM { get; set; }
        public UpdateProfileCommand(ProfileVM currentVM)
        {
            this.CurrentVM = currentVM;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            CurrentVM.UpdateNewProfile();
        }
    }
}
