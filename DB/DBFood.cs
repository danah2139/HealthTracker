using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;


namespace DB
{
    //we need 2 decide whether its by nutrient_no or report
    public class DBFood
    {
        private Dictionary<string, ReportObject.RootObject> FoodByReport = new Dictionary<string, ReportObject.RootObject>();
        public ReportObject.RootObject getFoodByReport(string report)
        {
            if (FoodByReport.ContainsKey(report))
                return FoodByReport[report];
            else
                return null;
        }


        public void setFoodByReport(string report, ReportObject.RootObject rootObject)
        {
            if (!FoodByReport.ContainsKey(report))
                FoodByReport.Add(report, rootObject);
            else
                FoodByReport[report] = rootObject;
        }
    }


}
