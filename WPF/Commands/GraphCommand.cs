using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.ViewModels;

namespace WPF.Commands
{
    public class GraphCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public event EventHandler ShowGraph;
        //public MainWindowVM CurrentVM { get; set; }

        //public GraphCommand(MainWindowVM currentVM)
        //{
        //    this.CurrentVM = currentVM;
        //}

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ShowGraph?.Invoke(this, new EventArgs());
            //CurrentVM.GraphCommand_ShowGraph();
            //this.CurrentVM.Operation(4);
        }


    }
}
