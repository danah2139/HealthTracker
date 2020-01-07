using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public class FoodBL
    {
        FoodDAL dal = new FoodDAL();
        
        public ReportObject.RootObject getFoodReportData(string name)
        {
            return dal.getFoodDataByName(name);
        }
        public User getUserDataById(string id)
        {
            return dal.getUser(id);
            
        }

        public void addUser(User user)
        {
            dal.addUser(user);
        }

        public void updateUser(User user)
        {
            dal.updateUser(user);
        }

        public List<KeyValuePair<string, double>> getGraphData(string id)
        {
            return dal.getGraphData(id);
        }


    }
}
