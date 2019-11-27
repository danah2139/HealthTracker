using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.ViewModels;

namespace WPF.Commands
{
    public class CancelProfileCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

            ((ProfileVM)parameter).close();
        }

    }
}
