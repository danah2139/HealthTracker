using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.ViewModels;

namespace WPF.Commands
{
    public class CheckLogInCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public LogInVM CurrentVM { get; set; }
        public CheckLogInCommand(LogInVM currentVM)
        {
            this.CurrentVM = currentVM;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            CurrentVM.CheckLogInNow();
        }
    }
}
