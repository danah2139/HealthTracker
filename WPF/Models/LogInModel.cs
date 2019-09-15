using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BE;


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

            return FoodBL.getUserDataById(Id);

        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }



    }
}
