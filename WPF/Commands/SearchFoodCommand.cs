using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.ViewModels;

namespace WPF.Commands
{
    public class SearchFoodCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public EnterMealsVM EnterMealsVM { get; set; }
        public SearchFoodCommand(EnterMealsVM EnterMealsVM)
        {
            this.EnterMealsVM = EnterMealsVM;

        }



        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            switch (int.Parse(parameter.ToString()))
            {
                case 1:
                    EnterMealsVM.SearchFood(1);
                    break;
                    
                case 2:
                    EnterMealsVM.SearchFood(2);
                    break;

                case 3:
                    EnterMealsVM.SearchFood(3);
                    break;

                case 4:
                    EnterMealsVM.SearchFood(4);
                    break;

                case 5:
                    EnterMealsVM.SearchFood(5);
                    break;

                case 6:
                    EnterMealsVM.SearchFood(6);
                    break;

                case 7:
                    EnterMealsVM.SearchFood(7);
                    break;

                case 8:
                    EnterMealsVM.SearchFood(8);
                    break;

                case 9:
                    EnterMealsVM.SearchFood(9);
                    break;

            }
        }
    }
}
