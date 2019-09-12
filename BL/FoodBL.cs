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
        public User getUserDataById(int id)
        {
            return dal.getUser(id);
            
        }

        public void addUser(User user)
        {
            dal.addUser(user);
        }

    }
}
