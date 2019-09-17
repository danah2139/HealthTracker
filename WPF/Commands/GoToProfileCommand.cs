using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.UserControls;
using WPF.ViewModels;

namespace WPF.Commands
{
    public class GoToProfileCommand : ICommand
    {
        public event EventHandler ShowNewProfile;
        public Profile Profile { get; set; }
        //public MainWindowVM MainWindowVM { get; set; }
        public GoToProfileCommand()
        {
         //   MainWindowVM = new MainWindowVM();

        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //MainWindowVM = new MainWindowVM();
            //MainWindowVM.UserControl = new Profile(); 
            ShowNewProfile?.Invoke(this, new EventArgs());
            //MainWindowVM = new MainWindowVM();
            //MainWindowVM.UserControl = new Profile(); 
        }
    }
}
