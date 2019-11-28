using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BE;
using System.Windows;

namespace WPF.Models
{
    public class GraphModel
    {
        public FoodBL FoodBL { get; set;}
        public GraphModel()
        {
            FoodBL = new FoodBL();

        }
       

        public List<KeyValuePair<string, double>> GetLstWeeksInformation(string userId) {

        
            var tempResult = FoodBL.getGraphData(userId);
            if (tempResult == null)
            {
                MessageBox.Show("Id not exist!");
                return null;
            }
            List<KeyValuePair<string, double>> result = new List<KeyValuePair<string, double>>();
            result = tempResult;
            return result;


        }
    }
}
