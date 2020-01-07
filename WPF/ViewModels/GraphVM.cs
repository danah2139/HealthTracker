using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Models;
using BE;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using WPF.UserControls;
using WPF.Commands;
using System.Windows.Forms;

namespace WPF.ViewModels
{
    public class GraphVM
    {
        public GraphModel GraphModel { get; set; }
        public Graph Graph { get; set; }
        public ICommand AddGraph { get; set; }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public ObservableCollection<KeyValuePair<string, double>> WeeksWeightInfo { get; set; }

        public GraphVM(string id)
        {
            GraphModel = new GraphModel();
            WeeksWeightInfo = new ObservableCollection<KeyValuePair<string, double>>(GraphModel.GetLstWeeksInformation(id));
        }



    }
}
