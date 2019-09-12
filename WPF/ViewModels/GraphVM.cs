using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Models;
using BE;
using System.Collections.ObjectModel;
using System.Windows.Controls;


namespace WPF.ViewModels
{
    public class GraphVM
    {
        GraphModel GraphModel { get; set; }
        public int Id { get; set; }
        //public ObservableCollection<WeekComleteWeightInfo> WeeksWeightInfo(GraphModel);
        public ObservableCollection<KeyValuePair<string, double>> WeeksWeightInfo { get; set; }

        public GraphVM(int id)
        {
            Id = id;
            GraphModel = new GraphModel();
            WeeksWeightInfo = new ObservableCollection<KeyValuePair<string, double>>(GraphModel.GetLstWeeksInformation(id));
            //FillCollection(id,weeks);
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
