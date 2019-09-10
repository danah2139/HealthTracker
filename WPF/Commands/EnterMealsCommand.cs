using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.Commands
{
    public class EnterMealsCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public event EventHandler ShowEnterMeals;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ShowEnterMeals?.Invoke(this, new EventArgs());
        }

    }
}
