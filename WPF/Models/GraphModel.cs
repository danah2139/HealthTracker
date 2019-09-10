using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BE;
namespace WPF.Models
{
    public class GraphModel
    {
        public FoodBL FoodBL { get; set;}
        public GraphModel()
        {
            FoodBL = new FoodBL();
        }
        public  User getUserInformation(int id)
        {
            return FoodBL.getUserDataById(id);
        }
        // add list essientail weight data
    }
}
