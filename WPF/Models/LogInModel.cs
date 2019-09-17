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
    public class LogInModel
    {
        public FoodBL FoodBL { get; set; }
        public LogInModel()
        {
            FoodBL = new FoodBL();

        }
        public User GetUserInfo()
        {
            if (Id == 0)
            {
                MessageBox.Show("please insert an Id");
                return null;
            }
            User user = FoodBL.getUserDataById(Id);
            if (user == null)
            {
                MessageBox.Show("Id not exist");
                return null;
            }
            MessageBox.Show("Sign In Successfully");
            return user;

        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }



    }
}
