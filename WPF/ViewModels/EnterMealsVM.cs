using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using WPF.Models;
using BL;
using System.Collections.ObjectModel;
using WPF.UserControls;
using BE;

namespace WPF.ViewModels
{
    public class EnterMealsVM

    {
       string Name;
       EnterMealsModel EnterMealsModel { get; set; }
       EnterMeals EnterMeals { get; set; }
       public EnterMealsVM()
       {
            EnterMealsModel = new EnterMealsModel();
       }

        public void SearchFood(int index)
        {

            Name = bindIndexToName(index); 
            ReportObject.RootObject rootObject = EnterMealsModel.getReportInformation(Name);

        }
        public string bindIndexToName(int index)
        {
            switch (index)
            {
                case 1:
                    return Name1;
                case 2:
                    return Name2;
                case 3:
                    return Name3;
                case 4:
                    return Name4;
                case 5:
                    return Name5;
                case 6:
                    return Name6;
                case 7:
                    return Name7;
                case 8:
                    return Name8;
                case 9:
                    return Name9;
            }
            return null;
        }

        private string name1;
        public string Name1
        {
            get { return name1; }
            set { name1 = value; }
        }


        private string name2;
        public string Name2
        {
            get { return name2; }
            set { name2 = value; }
        }

        private string name3;
        public string Name3
        {
            get { return name3; }
            set { name3 = value; }
        }

        private string name4;
        public string Name4
        {
            get { return name4; }
            set { name4 = value; }
        }

        private string name5;
        public string Name5
        {
            get { return name5; }
            set { name5 = value; }
        }

        private string name6;
        public string Name6
        {
            get { return name6; }
            set { name6 = value; }
        }

        private string name7;
        public string Name7
        {
            get { return name7; }
            set { name7 = value; }
        }

        private string name8;
        public string Name8
        {
            get { return name8; }
            set { name8 = value; }
        }

        private string name9;
        public string Name9
        {
            get { return name9; }
            set { name9 = value; }
        }

    }
}
