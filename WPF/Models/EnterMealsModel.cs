using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BE;

namespace WPF.Models
{
    public class EnterMealsModel
    {
      FoodBL FoodBL { get; set; }
      public EnterMealsModel(string name)
        {
            FoodBL = new FoodBL();
        }
        public ReportObject.RootObject getReportInformation(string name)
        {
            return FoodBL.getFoodReportData(name);
        }
        //we need to add lists/db for person

        //add list<> essientail food data public List<>
    }
}
