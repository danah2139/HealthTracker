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
        public LogInModel LogInModel { get; set; }
        public string userId;
        public GraphModel(string id)
        {
            FoodBL = new FoodBL();
            Id = id;

            //LogInModel = new LogInModel();
        }
       public void getId(string idLogIn)
        {
            this.Id = idLogIn;
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        //public  User getUserInformation(int id)
        //{
        //    return FoodBL.getUserDataById(id);
        //}
        //public List<WeekComleteWeightInfo> get
        public List<KeyValuePair<string, double>> GetLstWeeksInformation(string userId) {

            //string test = "205583610";
            //userId = LogInModel.Id;
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
