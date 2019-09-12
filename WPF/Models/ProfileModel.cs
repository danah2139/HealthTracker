using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;

namespace WPF.Models
{
    public class ProfileModel
    {
        public FoodBL FoodBL { get; set;}
        public ProfileModel()
        {
            FoodBL = new FoodBL();
            
        }
        public User GetUserInfo(int id)
        {

            return FoodBL.getUserDataById(id);

        }
        public void AddUser(User user)
        {
            FoodBL.addUser(user);
        }

    }
}
