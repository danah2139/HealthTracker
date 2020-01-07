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
using WPF.Commands;

namespace WPF.ViewModels
{
    public class EnterMealsVM

    {
       public EnterMealsModel EnterMealsModel { get; set; }
       public SearchFoodCommand SearchFoodCommand { get; set; }
       public EnterMeals EnterMeals { get; set; }
       public double [] Fat { get; set; }
       public double [] Protein { get; set; }
       public double [] Carbon { get; set; }
       public string[] Name { get; set; }
       public EnterMealsVM()
       {
            EnterMealsModel = new EnterMealsModel();
            SearchFoodCommand = new SearchFoodCommand(this);
            Name = new string[10];
            Fat = new double[10];
            Carbon = new double[10];
            Protein = new double[10];

        }

        public void SearchFood(int index)
        {
            String name = bindIndexToName(index); 
            ReportObject.RootObject rootObject = EnterMealsModel.getReportInformation(name);
            Fat[index] = rootObject.foods[0].food.desc.ff;
            Carbon[index] = rootObject.foods[0].food.desc.cf;
            Protein[index] = rootObject.foods[0].food.desc.pf;

        }
        public string bindIndexToName(int index)
        {
            switch (index)
            {
                case 1:
                    return Name[1];
                case 2:
                    return Name[2];
                case 3:
                    return Name[3];
                case 4:
                    return Name[4];
                case 5:
                    return Name[5];
                case 6:
                    return Name[6];
                case 7:
                    return Name[7];
                case 8:
                    return Name[8];
                case 9:
                    return Name[9];
            }
            return null;
        }


    }
}
