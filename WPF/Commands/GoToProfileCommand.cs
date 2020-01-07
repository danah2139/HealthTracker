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
    
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
          
            ((LogInVM)parameter).goToProfile();
        }
    }
}
