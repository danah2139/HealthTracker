using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.ViewModels;

namespace WPF.Commands
{
    public class EnterMealsCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public event EventHandler ShowEnterMeals;
        //public MainWindowVM CurrentVM { get; set; }
        //public EnterMealsCommand(MainWindowVM currentVM)
        //{
        //    this.CurrentVM = currentVM;
        //}

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
             ShowEnterMeals?.Invoke(this, new EventArgs());
            //CurrentVM.MealCommand_ShowEnterMeals();
            //this.CurrentVM.Operation(3);
        }

    }
}
