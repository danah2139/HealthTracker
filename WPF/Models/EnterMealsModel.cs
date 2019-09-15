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
        public FoodBL FoodBL { get; set; }
        public EnterMealsModel()
        {
            FoodBL = new FoodBL();
        }
        public ReportObject.RootObject getReportInformation(string name)
        {
            return FoodBL.getFoodReportData(name);
        }

        public string[] getListOfFoodDetails()
        {
            string[] details = { "Name", "Fat", "Protein", "Carbohydrate" };
            return details;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //we need to add lists/db for person

        //add list<> essientail food data public List<>
    }
}
