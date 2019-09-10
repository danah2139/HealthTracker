using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using WPF.Models;
using BL;
using System.Collections.ObjectModel;

namespace WPF.ViewModels
{
    public class EnterMealsVM:ObservableCollection<ReportObject>
        //it makes sense ,cause we want to inform our model
        //when the a report is being addaed,and thatd in ReportObject
        //and we r entering meals
    {
        EnterMealsModel EnterMealsModel { get; set; }
        //public string Sr { get; set; }
       public EnterMealsVM(string name)
        {
           // Sr = sr;
            EnterMealsModel = new EnterMealsModel(name);

        }
    }
}
