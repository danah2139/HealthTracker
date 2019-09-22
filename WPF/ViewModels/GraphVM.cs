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
        //public ObservableCollection<WeekComleteWeightInfo> WeeksWeightInfo(GraphModel);
        public ObservableCollection<KeyValuePair<string, double>> WeeksWeightInfo { get; set; }

        public GraphVM()
        {
            //Id = id;
            GraphModel = new GraphModel();
            AddGraph = new AddToGraphCommand(this);
            //WeeksWeightInfo = new ObservableCollection<KeyValuePair<string, double>>();
            WeeksWeightInfo = new ObservableCollection<KeyValuePair<string, double>>(GraphModel.GetLstWeeksInformation());
            //FillCollection(id,weeks);
        }

        public void AddNewGraph()
        {
              GraphModel.GetLstWeeksInformation();
        //    this.WeeksWeightInfo = new ObservableCollection<KeyValuePair<string, double>>(GraphModel.GetLstWeeksInformation());

        }



        //private void FillCollection(int id,DateTime[] weeks)
        //{
        //    User userData = new User();//check if to change to return List
        //    foreach(DateTime week in weeks)
        //    {
        //        userData = GraphModel.getUserInformation(id);
        //        WeeksWeightInfo.Add(
        //            new WeekComleteWeightInfo
        //            {
        //                CurrentDate = week,
        //                User = userData
        //            });

        //    }
        //}
    }
}
