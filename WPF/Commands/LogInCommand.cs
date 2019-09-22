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
        //public MainWindowVM CurrentVM { get; set; }
        //public LogInCommand(MainWindowVM currentVM)
        //{
        //    this.CurrentVM = currentVM;

        //}
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ShowLogIn?.Invoke(this, new EventArgs());
            //CurrentVM.LogInCommand_ShowlogIn();
           // CurrentVM.Operation(1);
        }
    }
}
