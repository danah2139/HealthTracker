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
        public GraphModel GraphModel { get; set; }
        public LogInModel()
        {
            FoodBL = new FoodBL();
            //GraphModel = new GraphModel();

        }
        public User GetUserInfo()
        {
            if (Id == "")
            {
                MessageBox.Show("please insert an Id");
                return null;
            }
            User user = FoodBL.getUserDataById(Id);
            if (user == null)
            {
                MessageBox.Show("Id doe's not exist");
                return null;
            }
            MessageBox.Show("Sign In Successfully");
            return user;

        }

        public string id;
        public string Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                }
            }
        }



    }
}
