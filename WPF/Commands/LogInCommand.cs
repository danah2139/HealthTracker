using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.ViewModels;

namespace WPF.Commands
{
    public class LogInCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public event EventHandler ShowLogIn;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ShowLogIn?.Invoke(this, new EventArgs());

        }
    }
}
