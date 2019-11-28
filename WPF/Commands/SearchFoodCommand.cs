using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.ViewModels;

namespace WPF.Commands
{
    class SearchFoodCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            switch (int.Parse(parameter.ToString()))
            {
                case 1:
                    ((EnterMealsVM)parameter).SearchFood(1);
                    break;
                    
                case 2:
                    ((EnterMealsVM)parameter).SearchFood(2);
                    break;

                case 3:
                    ((EnterMealsVM)parameter).SearchFood(3);
                    break;

                case 4:
                    ((EnterMealsVM)parameter).SearchFood(4);
                    break;

                case 5:
                    ((EnterMealsVM)parameter).SearchFood(5);
                    break;

                case 6:
                    ((EnterMealsVM)parameter).SearchFood(6);
                    break;

                case 7:
                    ((EnterMealsVM)parameter).SearchFood(7);
                    break;

                case 8:
                    ((EnterMealsVM)parameter).SearchFood(8);
                    break;

                case 9:
                    ((EnterMealsVM)parameter).SearchFood(9);
                    break;

            }
        }
    }
}
